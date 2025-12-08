using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BayazitovEA.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Сортируем строки по 4-му столбцу (индекс 3)
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (matrix[i, 3] > matrix[j, 3])
                    {
                        // Меняем строки i и j местами
                        for (int k = 0; k < columns; k++)
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[j, k];
                            matrix[j, k] = temp;
                        }
                    }
                }
            }
            return matrix;
        }
    }
}