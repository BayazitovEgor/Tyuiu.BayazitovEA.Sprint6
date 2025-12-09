using Tyuiu.BayazitovEA.Sprint6.Task4.V30.Lib;
namespace Tyuiu.BayazitovEA.Sprint6.Task4.V30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds=new DataService();
        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = -5;
                int stopStep = 5;

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
            }
            catch
            {
                MessageBox.Show("введены неверные данные", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
