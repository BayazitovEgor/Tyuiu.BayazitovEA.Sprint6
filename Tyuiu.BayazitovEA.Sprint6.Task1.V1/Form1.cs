using System.Windows.Forms.VisualStyles;
using Tyuiu.BayazitovEA.Sprint6.Task1.V1.Lib;
namespace Tyuiu.BayazitovEA.Sprint6.Task1.V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 ds=new Class1();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRes.Text = "";
                textBoxRes.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRes.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxRes.AppendText("+----------+----------+" + Environment.NewLine);

                for(int i =0; i <= len-1;i++)
                {
                    strLine = String.Format("|{0,5:d}    |  {1, 5:f2}   | ", startStep, valueArray[i]);
                    textBoxRes.AppendText(strLine+Environment.NewLine);
                    startStep++;
                }
                textBoxRes.AppendText("+----------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("введены неверные данные", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
