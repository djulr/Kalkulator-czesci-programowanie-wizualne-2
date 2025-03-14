using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_części___programowanie_wizualne_2
{
    public partial class Form2 : Form
    {

        public double SUM
        {
            get { return ProcessorPrice + DrivePrice; }
        }



        double ProcessorPrice = 0;
        double DrivePrice = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Monitor(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox2.SelectedIndex)
            {
                case 0:
                    DrivePrice = 1570.59;
                    break;
                case 1:
                    DrivePrice = 1239.99;
                    break;
                case 2:
                    DrivePrice = 1666.66;
                    break;
                case 3:
                    ProcessorPrice = 1239.99;
                    break;
                case 4:
                    ProcessorPrice = 1666.66;
                    break;
            }
            richTextBox2.Text = DrivePrice.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    ProcessorPrice = 1570.59;
                    break;
                case 1:
                    ProcessorPrice = 1239.99;
                    break;
                case 2:
                    ProcessorPrice = 1666.66;
                    break;

            }
            richTextBox1.Text = ProcessorPrice.ToString();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            double SUM = ProcessorPrice + DrivePrice;
            richTextBox3.Text = SUM.ToString();
        }
    }
}
