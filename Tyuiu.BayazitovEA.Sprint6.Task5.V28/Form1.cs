using Tyuiu.BayazitovEA.Sprint6.Task5.V28.Lib;

namespace Tyuiu.BayazitovEA.Sprint6.Task5.V28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6";
        private void button1_Click(object sender, EventArgs e)
        {
            double[] numsMass = new double[ds.len];
            numsMass=ds.LoadFromDataFile(path);

        }
    }
}
