using Tyuiu.BayazitovEA.Sprint6.Task0.V6.Lib;
namespace Tyuiu.BayazitovEA.Sprint6.Task0.V6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBox1.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox2.Text)));
            }
            catch 
            {
                MessageBox.Show("введены неверные данные","ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
