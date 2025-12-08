using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BayazitovEA.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Собираем значения 4-го столбца (индекс 3)
            int[] fourthColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                fourthColumn[i] = matrix[i, 3];
            }

            // Сортируем значения 4-го столбца
            Array.Sort(fourthColumn);

            // Заменяем значения в 4-м столбце на отсортированные
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 3] = fourthColumn[i];
            }

            return matrix;
        }
    }
}