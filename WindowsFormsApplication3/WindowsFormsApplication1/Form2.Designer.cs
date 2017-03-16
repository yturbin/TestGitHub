namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMyStatusString = new System.Windows.Forms.StatusStrip();
            this.textBoxMyInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolStripMyStatusString
            // 
            this.toolStripMyStatusString.Location = new System.Drawing.Point(0, 239);
            this.toolStripMyStatusString.Name = "toolStripMyStatusString";
            this.toolStripMyStatusString.Size = new System.Drawing.Size(284, 22);
            this.toolStripMyStatusString.TabIndex = 0;
            this.toolStripMyStatusString.Text = "statusStrip1";
            // 
            // textBoxMyInput
            // 
            this.textBoxMyInput.Location = new System.Drawing.Point(118, 106);
            this.textBoxMyInput.Name = "textBoxMyInput";
            this.textBoxMyInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxMyInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(73, 182);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "button1";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMyInput);
            this.Controls.Add(this.toolStripMyStatusString);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip toolStripMyStatusString;
        private System.Windows.Forms.TextBox textBoxMyInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
    }
}