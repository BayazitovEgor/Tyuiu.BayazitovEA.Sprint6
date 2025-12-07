namespace Tyuiu.BayazitovEA.Sprint6.Task0.V6
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
            buttondone = new Button();
            textBox1 = new TextBox();
            textBoxInPut = new TextBox();
            buttonHelp = new Button();
            SuspendLayout();
            // 
            // buttondone
            // 
            buttondone.FlatStyle = FlatStyle.Flat;
            buttondone.Location = new Point(649, 345);
            buttondone.Name = "buttondone";
            buttondone.Size = new Size(128, 93);
            buttondone.TabIndex = 0;
            buttondone.Text = "run";
            buttondone.UseVisualStyleBackColor = true;
            buttondone.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(649, 316);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBoxInPut
            // 
            textBoxInPut.Location = new Point(293, 316);
            textBoxInPut.Name = "textBoxInPut";
            textBoxInPut.Size = new Size(124, 23);
            textBoxInPut.TabIndex = 2;
            textBoxInPut.TextChanged += textBoxInPut_TextChanged;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(568, 356);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 71);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(textBoxInPut);
            Controls.Add(textBox1);
            Controls.Add(buttondone);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttondone;
        private TextBox textBox1;
        private TextBox textBoxInPut;
        private Button buttonHelp;
    }
}
