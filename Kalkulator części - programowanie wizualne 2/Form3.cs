using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kalkulator_części___programowanie_wizualne_2;

namespace Kalkulator_części___programowanie_wizualne_2
{
    public partial class Form3 : Form
    {
       double MonitorPrice = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    MonitorPrice = 2124.59;
                    break;
                case 1:
                    MonitorPrice = 3560.99;
                    break;
                case 2:
                    MonitorPrice = 2895.95;
                    break;
                case 3:
                    MonitorPrice = 1339.99;
                    break;
                case 4:
                    MonitorPrice = 2999.99;
                    break;
                case 5:
                    MonitorPrice = 4420.37;
                    break;
            }
            SharedData.Wartosc3 = MonitorPrice;
            richTextBox1.Text = MonitorPrice.ToString();
        }
    }
}
