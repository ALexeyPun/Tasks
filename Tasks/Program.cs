using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 54: Задайте двумерный массив.Напишите программу, 
            // которая упорядочит по убыванию элементы каждой строки двумерного массива.
            
            MyMethods.FileHeader(54);
            Console.WriteLine("Задайте двумерный массив. Напишите программу, \r\nкоторая упорядочит по убыванию элементы каждой строки двумерного массива.");
            Console.WriteLine();
            Console.WriteLine("Создание массива.");
            int lines = MyMethods.GetNumberFromConsole("Введите колличество строк: ");
            int columns = MyMethods.GetNumberFromConsole("Введите колличество колонок: ");

            int[,] firstArray = MyMethods.Create2DArray(lines, columns);

            Console.WriteLine("Нужны значения для рандомизации.");
            int minValue = MyMethods.GetNumberFromConsole("Введите минимальное значение: ");
            int maxValue = MyMethods.GetNumberFromConsole("Введите максимальное значение: ");

            MyMethods.FillArrayRandom(firstArray, minValue, maxValue);
            MyMethods.Print2DArray(firstArray);
            
            MyMethods.Sort2DArrayFromMaxToMin(firstArray);
            MyMethods.Print2DArray(firstArray);
                        
            Console.WriteLine("Программа завершена.");
            Console.ReadKey();


            // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
            // которая будет находить строку с наименьшей суммой элементов.

            Console.Clear();
            Console.WriteLine("Задание 56.");
            Console.WriteLine();
            Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, \r\nкоторая будет находить строку с наименьшей суммой элементов.");
            Console.WriteLine();

            Console.WriteLine("Создание массива.");
            lines = MyMethods.GetNumberFromConsole("Введите колличество строк: ");
            columns = MyMethods.GetNumberFromConsole("Введите колличество колонок: ");


            int[,] secondArray = MyMethods.Create2DArray(lines, columns);

            Console.WriteLine("Нужны значения для рандомизации.");
            minValue = MyMethods.GetNumberFromConsole("Введите минимальное значение: ");
            maxValue = MyMethods.GetNumberFromConsole("Введите максимальное значение: ");

            MyMethods.FillArrayRandom(secondArray, minValue, maxValue);
            MyMethods.Print2DArray(secondArray);

            int indexMinVaueLine = MyMethods.GetMinLineIndex(secondArray);
            Console.WriteLine($"Индекс линии с минимальным значением - {indexMinVaueLine}");
            Console.WriteLine();
            Console.WriteLine("Программа завершена.");
            Console.ReadKey();



            // Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.

            Console.Clear();
            Console.WriteLine("Задание 58.");
            Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
            Console.WriteLine();

            int[,] matrixA = MyMethods.CreateMatrix("Создайте матрицу А.");
            int[,] matrixB = MyMethods.CreateMatrix("Создайте матрицу В.");

            MyMethods.Print2DArray(matrixA);
            MyMethods.Print2DArray(matrixB);

            int[,] rezultMatrix = MyMethods.ProductOfTwoMatrices(matrixA, matrixB);

            Console.WriteLine("Результат умножения матриц.");
            Console.WriteLine();
            MyMethods.Print2DArray(rezultMatrix);
            Console.WriteLine("Программа завершена.");
            Console.ReadKey();



            // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
            // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
            // Массив размером 2 x 2 x 2

            Console.Clear();
            Console.WriteLine("Задание 60.");
            Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");
            Console.WriteLine("Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
            Console.WriteLine();

            int[,,] array3D = new int[2, 2, 2];

            MyMethods.Fill3DArray(array3D);

            MyMethods.Print3DArray(array3D);
            Console.WriteLine("Программа завершена.");
            Console.ReadKey();


            // Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.

            Console.Clear();
            Console.WriteLine("Задание 62.");
            Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4.");
            Console.WriteLine();

            lines = MyMethods.GetNumberFromConsole("Введите количество линий: ");
            columns = MyMethods.GetNumberFromConsole("Введите количество линий: ");

            int[,] array = MyMethods.Create2DArray(lines, columns);

            MyMethods.FillArraySpirally(array);
            MyMethods.PrintArraySpirally(array);

            Console.ReadKey();
            
        }
    }
}
