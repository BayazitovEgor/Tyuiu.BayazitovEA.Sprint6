using Tyuiu.BayazitovEA.Sprint6.Task6.V29.Lib;
namespace Tyuiu.BayazitovEA.Sprint6.Task6.V29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string openFilePath;

        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath=openFileDialog1.FileName;
            textBox2.Text = File.ReadAllText(openFilePath);
            groupBox1.Text=groupBox1.Text+" "+openFileDialog1.FileName;
            button1.Enabled = true;
        }
    }
}
