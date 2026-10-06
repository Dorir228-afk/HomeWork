using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lesson6
{
    internal class calculator
    {
        public double Sum(double[] numbers)
        {
            var result = 0.0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }

        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Myltply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }
        public double modles(double num1, double num2)
        {
            return num1 % num2;
        }
        public int count(double[] numbers)
        {
            return numbers.Length;
        }
        public double Max(double[] numbers)
        {
            var result = 0.0;
            foreach (var number in numbers)
            {
                if (result < number)
                {
                    result = number;
                }
            }
            return result;

        }
        public double Min(double[] numbers)
        {
            var result = 0.0;
            foreach (var number in numbers)
            {
                if (result > number)
                {
                    result = number;
                }
            }
            return result;

        }

        public double precenet(double Total, float precent)
        {
            return Convert.ToSingle(Total * precent / 100);
        }
        public double FinalPrice(double Total, float precent)
        {
            return Total * (1 - precent / 100);
        }

    }
}
