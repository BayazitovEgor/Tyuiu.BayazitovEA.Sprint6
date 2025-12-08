using Tyuiu.BayazitovEA.Sprint6.Task3.V17.Lib;
namespace Tyuiu.BayazitovEA.Sprint6.Task3.V17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {{ 22,  32, - 16 , 24 , 27 },
                                     { 3, -20 , 24, -20 , 25 },
                                     { 21 , 17 , -8, -19 , 17 },
                                     { 8 , 22,  28,  27,  19 },
                                     { 11 , 20 , 12 , 27 , 29}};
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxRes.Text=Convert.ToString(ds.Calculate(mtrx));
        }
    }
}
