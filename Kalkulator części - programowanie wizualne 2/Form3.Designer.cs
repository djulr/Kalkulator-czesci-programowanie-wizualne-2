namespace Kalkulator_części___programowanie_wizualne_2
{
    partial class Form3
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
            listBox1 = new ListBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(66, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(654, 388);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 497);
            label1.Name = "label1";
            label1.Size = new Size(68, 32);
            label1.TabIndex = 1;
            label1.Text = "Cena";
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(168, 494);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(196, 45);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 501);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 3;
            label2.Text = "PLN";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 592);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form3";
            Text = "Monitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
    }
}