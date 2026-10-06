using System;
using System.Collections.Generic;
using System.Text;

namespace lesson6
{
    internal class GUIConsolApp
    {
        public double[] GetArray(double[] array)
        {
            Console.Write($"Enter Array Length: ");
            array = new double[int.Parse(Console.ReadLine())];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter Value {i}:");
                array[i] = (double.Parse(Console.ReadLine()));
            }
            return array;//рш ьщрфьув
        }
    }
}
