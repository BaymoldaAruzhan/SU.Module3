//Удалить те столбцы, в которых встречается хотя бы два одинаковых элемента

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {1, 5, 6}
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Метод для проверки, есть ли хотя бы два одинаковых элемента в столбце
        bool HasDuplicateElements(int columnIndex)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < rows; i++)
            {
                if (!set.Add(matrix[i, columnIndex]))
                {
                    return true;
                }
            }
            return false;
        }

        List<int> columnsToRemove = new List<int>();

        for (int j = 0; j < cols; j++)
        {
            if (HasDuplicateElements(j))
            {
                columnsToRemove.Add(j);
            }
        }

        // Создаем новую матрицу с удаленными столбцами
        int[,] newMatrix = new int[rows, cols - columnsToRemove.Count];
        int index = 0;

        for (int j = 0; j < cols; j++)
        {
            if (!columnsToRemove.Contains(j))
            {
                for (int i = 0; i < rows; i++)
                {
                    newMatrix[i, index] = matrix[i, j];
                }
                index++;
            }
        }

        // Вывод новой матрицы
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols - columnsToRemove.Count; j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
        }

    }
}
