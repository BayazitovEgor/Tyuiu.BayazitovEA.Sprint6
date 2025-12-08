using Tyuiu.BayazitovEA.Sprint6.Task2.V7.Lib;
namespace Tyuiu.BayazitovEA.Sprint6.Task2.V7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chart1.Titles.Add("График функции");
                this.chart1.ChartAreas[0].AxisX.Title = "ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chart1.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("введены неверные данные", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFunction_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
