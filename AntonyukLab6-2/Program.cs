using System;

public class MathOperations
{
    // Перевантажений метод для додавання чисел
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Перевантажений метод для додавання масивів чисел
    public static int[] Add(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            throw new ArgumentException("Arrays must have the same length");
        }

        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] + arr2[i];
        }

        return result;
    }

    // Перевантажений метод для додавання матриць
    public static int[,] Add(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }

        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    // Перевантажений метод для додавання тензорів
    public static int[,,] Add(int[,,] tensor1, int[,,] tensor2)
    {
        int dim1 = tensor1.GetLength(0);
        int dim2 = tensor1.GetLength(1);
        int dim3 = tensor1.GetLength(2);

        if (dim1 != tensor2.GetLength(0) || dim2 != tensor2.GetLength(1) || dim3 != tensor2.GetLength(2))
        {
            throw new ArgumentException("Tensors must have the same dimensions");
        }

        int[,,] result = new int[dim1, dim2, dim3];
        for (int i = 0; i < dim1; i++)
        {
            for (int j = 0; j < dim2; j++)
            {
                for (int k = 0; k < dim3; k++)
                {
                    result[i, j, k] = tensor1[i, j, k] + tensor2[i, j, k];
                }
            }
        }

        return result;
    }

    // Додайте перевантажені методи для віднімання, множення та інших операцій за необхідності
    // ...

    // Приклад використання
    public static void Main()
    {
        Console.WriteLine(Add(5, 3)); // Виведе 8

        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] resultArray = Add(array1, array2);
        Console.WriteLine(string.Join(", ", resultArray)); // Виведе 5, 7, 9

        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        int[,] resultMatrix = Add(matrix1, matrix2);
        Console.WriteLine($"{resultMatrix[0, 0]}, {resultMatrix[0, 1]}\n{resultMatrix[1, 0]}, {resultMatrix[1, 1]}");
        // Виведе:
        // 6, 8
        // 10, 12
    }
}
