using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    internal class GUIConsolApp
    {
        public double[] GetArray(double[] array)
        {
            Console.Write($"Введите длину массива: ");
            array = new double[int.Parse(Console.ReadLine())];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите значение {i}:");
                array[i] = (double.Parse(Console.ReadLine()));
            }
            return array;
        }
    }
}
