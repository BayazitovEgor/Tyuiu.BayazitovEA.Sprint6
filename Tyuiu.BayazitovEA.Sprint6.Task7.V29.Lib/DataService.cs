using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.BayazitovEA.Sprint6.Task7.V29.Lib
{
    public class DataService : ISprint6Task7V29
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            for (int c = 0; c < columns; c++)
            {
                int value = arrayValues[4, c]; 
                if (value >= -5 && value <= 10)
                {
                    arrayValues[4, c] = 99;
                }
            }

            return arrayValues;
        }
    }
}