namespace Tyuiu.BayazitovEA.Sprint6.Task1.V1
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
            buttonDone = new Button();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            textBoxRes = new TextBox();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(697, 385);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 23);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "RUN";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(94, 334);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 1;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(263, 334);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 2;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(505, 57);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(283, 273);
            textBoxRes.TabIndex = 3;
            textBoxRes.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxRes);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(buttonDone);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private TextBox textBoxRes;
    }
}
