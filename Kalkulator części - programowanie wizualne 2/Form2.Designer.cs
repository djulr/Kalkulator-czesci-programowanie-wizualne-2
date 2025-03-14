namespace Kalkulator_części___programowanie_wizualne_2
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
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            listBox2 = new ListBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            richTextBox3 = new RichTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 66);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 0;
            label1.Text = "Procesor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 283);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 1;
            label2.Text = "Dysk";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(146, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(181, 63);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(146, 266);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(181, 63);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Items.AddRange(new object[] { "Seagate Barracuda 1TB", "Western Digital Blue 500GB", "Samsung 970 EVO Plus 1TB SSD", "Toshiba Canvio Basics 2TB", "Crucial MX500 500GB SSD" });
            listBox2.Location = new Point(35, 383);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(563, 164);
            listBox2.TabIndex = 5;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AMD Ryzen 7700X", "Intel Core i9 12900KF", "Intel Core i7-14700KF" });
            comboBox1.Location = new Point(35, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(563, 40);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 615);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 7;
            label3.Text = "Suma";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(146, 589);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(168, 66);
            richTextBox3.TabIndex = 8;
            richTextBox3.Text = "";
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 615);
            label4.Name = "label4";
            label4.Size = new Size(56, 32);
            label4.TabIndex = 9;
            label4.Text = "PLN";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 836);
            Controls.Add(label4);
            Controls.Add(richTextBox3);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(listBox2);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Komputer";
            Load += Monitor;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private ListBox listBox2;
        private ComboBox comboBox1;
        private Label label3;
        private RichTextBox richTextBox3;
        private Label label4;
    }
}