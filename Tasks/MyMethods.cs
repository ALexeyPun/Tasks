using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public static class MyMethods
    {
        public static void FileHeader(int numberTask)
        {
            Console.WriteLine("Домашняя работа Паньшина Алексея.");
            Console.WriteLine();
            Console.WriteLine($"Задание {numberTask}.");
            Console.WriteLine();
        }

        public static int GetNumberFromConsole(string message)
        {
            Console.Write(message);
            int number = 0;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number)) break;
                Console.Write("Попробуйте снова!");
            }
            Console.WriteLine();
            return number;
        }

        public static int[,] Create2DArray(int lines, int columns)
        {
            int[,] array = new int[lines, columns];
            return array;
        }

        public static void FillArrayRandom(int[,] array, int minValue, int maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }
        }

        public static void Print2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j  < array.GetLength(1); j ++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Sort2DArrayFromMaxToMin(int[,] array)
        {
            int maxValue = 0;
            int lines = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {                    
                    for (int k = 0; k < columns - 1; k++)
                    {
                        if (array[i, k] < array[i, k + 1])
                        {
                            maxValue = array[i, k + 1];
                            array[i, k + 1] = array[i, k];
                            array[i, k] = maxValue;
                        }
                    }                    
                }
            }

        }

        public static int GetMinLineIndex(int[,] array2D)
        {
            int minValue = 0;
            int sumElements = 0;
            int indexMinLine = 0;
            int[] array = new int[array2D.GetLength(0)];

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                sumElements = 0;
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    sumElements += array2D[i, j];
                }
                array[i] = sumElements;
            }
            minValue = array.Min();
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == minValue)
                {
                    indexMinLine = i;
                    break;
                }
            }
            return indexMinLine;
        }

        public static int[,] CreateMatrix(string message)
        {
            Console.WriteLine(message);
            int[,] matrix = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix[i,j] = MyMethods.GetNumberFromConsole($"Введите {j + 1} значение {i + 1} строки: ");
                }
            }
            return matrix;
        }

        public static int[,] ProductOfTwoMatrices(int[,] matrixA, int[,] matrixB)
        {
            int lines = matrixA.GetLength(0);
            int columns = matrixA.GetLength(1);
            int[,] rezultMatrix = new int[lines,columns];

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < lines; k++)
                    {
                        rezultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }                   
                }
            }

            return rezultMatrix;

        }

        public static void Fill3DArray(int[,,] array)
        {
            int axisX = array.GetLength(0);
            int axisY = array.GetLength(1);
            int axisZ = array.GetLength(2);
            int number = 10;

            for (int i = 0; i < axisX; i++)
            {
                for (int j = 0; j < axisY; j++)
                {
                    for (int k = 0; k < axisZ; k++)
                    {
                        array[i, j, k] = number++;
                                                
                    }
                }
            }
        }

        public static void Print3DArray(int[,,] array)
        {
            Console.WriteLine("Трёхмкрный массив создан.");
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"({i} {j} {k}) = {array[i, j, k]}  ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();                        
        }

        public static void FillArraySpirally(int[,] array)
        {
            int lines = array.GetLength(0) - 1;
            int columns = array.GetLength(1) - 1;
            int countElements = (lines + 1) * (columns + 1);
            int counter = 0;
            int circle = 0;
            int i = 0;
            int j = 0;

            while (counter < countElements)
            {
                for (; j <= columns - circle; j++)
                    array[i, j] = ++counter;
                j--;
                i++;

                for (; i <= lines - circle; i++)
                    array[i, j] = ++counter;
                i--;
                j--;

                for (; j >= 0 + circle; j--)
                    array[i, j] = ++counter;
                j++;
                i--;
                circle++;

                for (; i >= 0 + circle; i--)
                    array[i, j] = ++counter;
                i++;
                j++;
            }
                       
        }

        public static void PrintArraySpirally(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if(array[i, j] < 10)
                        Console.Write("0" + array[i, j] + " ");
                    else
                        Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
