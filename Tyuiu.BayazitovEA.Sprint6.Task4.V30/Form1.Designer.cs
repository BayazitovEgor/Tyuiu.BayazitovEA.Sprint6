namespace Tyuiu.BayazitovEA.Sprint6.Task4.V30
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonRun = new Button();
            SuspendLayout();
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(615, 373);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(75, 23);
            buttonRun.TabIndex = 0;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRun);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRun;
    }
}
