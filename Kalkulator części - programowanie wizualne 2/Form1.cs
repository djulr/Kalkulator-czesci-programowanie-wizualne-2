

using Kalkulator_części___programowanie_wizualne_2;
namespace Kalkulator_części___programowanie_wizualne_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); 
            form3.Show(); 
        }

      

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            double price = (SharedData.Wartosc2 + SharedData.Wartosc3);
            richTextBox1.Text = price.ToString();
        }
    }
}
