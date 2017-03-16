using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private int sum;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Start");

            ////Task.Run((Func<Task>) TestAsync);
            ////Task t = TestAsync();
            ////t.Wait();
            ////await TestAsync();
            //Task.Delay(TimeSpan.FromSeconds(5));
            //await TestAsync2();
            //Task.Run((Func<Task>)TestAsync2).ConfigureAwait(false);
            //var tesk = TestAsync2();
            //tesk.Wait();
            //MessageBox.Show("Finish");

            //await CallMyMethodAsync();

            TestParallel();
        }

        private void TestParallel()
        {
            IList<string> sc = new List<string>();
            int i;
            for (i = 0; i < 100000000; i++)
            {
                sc.Add("Test");
            }

            //var sw = new Stopwatch();

            //sw.Start();
            int h = 0;
            //foreach (var str in sc)
            //{
            //    h++;
            //}
            //sw.Stop();
            //var withoutParallel = sw.ElapsedMilliseconds;

            //sw.Restart();

            //Parallel.ForEach(sc, (str,
            //    state) =>
            //{
            //    h++;
            //});
            Parallel.ForEach(sc, () => 0, (item, state, localValue) => localValue + 1, localValue =>
            {
                    h += localValue;
            });
            //sw.Stop();
            //var withParallel = sw.ElapsedMilliseconds;
            //sc.AsParallel().Sum()
          //  MessageBox.Show(string.Format("Without: {0}, with: {1}", withoutParallel, withParallel));
            MessageBox.Show(h.ToString());
        }

        private void StringTest(string str)
        {
            var i = str.Length;
        }

        static async Task CallMyMethodAsync()
        {
            var progress = new Progress<int>();
            int i = 0;
            progress.ProgressChanged += (sender, args) =>
            {
                i++;
            };
            await MyMethodAsync(progress);
            MessageBox.Show(progress.ToString());
        }

        static async Task MyMethodAsync(IProgress<int> progress = null)
        {
            Task.Delay(TimeSpan.FromSeconds(5));
            int percentComplete = 0;
            for (percentComplete = 0; percentComplete < 500000; percentComplete++)
            {
                if (progress != null)
                    progress.Report(percentComplete);
                percentComplete++;
            }
            //MessageBox.Show(percentComplete.ToString());
        }

        private async Task TestAsync()
        {
            Task.Run((Func<Task<int>>)AddAndMultiplyAsync);
            //await AddAndMultiplyAsync(1, 2, 3);
        }

        public async Task<int> AddAndMultiplyAsync()
        {
            Thread.Sleep(2000);
            MessageBox.Show("Inside");
            return 4 + 5 + 6;
        }

        private async Task MyMethodAsync()
        {
            Task<int> taskA = AddAndMultiplyAsync();
            await Task.WhenAll(taskA);
        }

        static async Task<int> DelayAndReturnAsync(int val)
        {
            await Task.Delay(TimeSpan.FromSeconds(val));
            return val;
        }
        // Currently, this method prints "2", "3", and "1".
        // We want this method to print "1", "2", and "3".
        static async Task ProcessTasksAsync()
        {
            // Create a sequence of tasks.
            Task<int> taskA = DelayAndReturnAsync(2);
            Task<int> taskB = DelayAndReturnAsync(3);
            Task<int> taskC = DelayAndReturnAsync(1);
            var tasks = new[] { taskA, taskB, taskC };
            // Await each task in order.

            var processingTasks = tasks.Select(async t =>
            {
                var result = await t;
                MessageBox.Show(result.ToString());
            }).ToArray();
            // Await all processing to complete
            await Task.WhenAll(processingTasks);
        }

        static async Task ThrowExceptionAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            throw new InvalidOperationException("Test");
        }

        static async Task TestAsync2()
        {
            try
            {
                await ThrowExceptionAsync();
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public int GetSum(int x, int y)
        {
            return 0;
        }

        public int GetSum2(int x, int y)
        {
            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));

            CancellationToken ct;
            return 0;
        }
    }
}
