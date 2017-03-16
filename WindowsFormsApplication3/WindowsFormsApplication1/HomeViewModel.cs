using System;
using ReactiveUI;
using ReactiveUI.Legacy;


namespace WindowsFormsApplication1
{
    public class HomeViewModel : ReactiveObject
    {
        string ModelString;
		public string EnteredText
		{
			get { return ModelString; }
			set { this.RaiseAndSetIfChanged( ref ModelString, value);}
		}

		string statusString = "";
		public string Status
		{
			get{return statusString;}
			set{this.RaiseAndSetIfChanged(ref statusString,value);}
		}

		public ReactiveCommand<object> OKCmd { get; private set; }
        private Action<object> save;
		public HomeViewModel()
		{
			var OKCmdObs = this.WhenAny(vm => vm.EnteredText, 
				s => !string.IsNullOrWhiteSpace(s.Value));
			OKCmd = ReactiveUI.Legacy.ReactiveCommand.Create(OKCmdObs);
            save = Save();
            OKCmd.Subscribe(save);
		    
		}

        private Action<object> Save()
        {
            return _ => Status = EnteredText + " is saved.";
        }
    }
}
