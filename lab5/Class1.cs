using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab5
{
    class Class1
    {
        public double inch_to_cm(double n)
        {
           
            if (n < 0) throw new ArgumentException("Некорректный ввод. Введено отрицательное число.");
            if (n > double.MaxValue/2.54) throw new ArgumentException("Некорректный ввод. Выход за пределы допустимого значения.");
            n = n * 2.54;
            return n;
        }

        
        public bool parity(int n)
        {
            return (n % 2 == 0) ? true : false;
        }

        
        public int max_value(int[] array)
        {
            int i; int max;

            for (i = 0; i < array.Length; i++) Console.WriteLine(array[i]);
               
            max = array[0];

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i]; 
            }

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] > int.MaxValue) throw new ArgumentException("Некорректный ввод. Выход за пределы допустимого значения.");
                if (array[i] < int.MaxValue) throw new ArgumentException("Некорректный ввод. Выход за пределы допустимого значения.");
                if (array [i]<0) throw new ArgumentException("Некорректный ввод. Введено отрицательное число.");
            }

                return max;
        }

       
        public double division(double n, int m)
        {
            if (m <= 0) throw new ArgumentException("Некорректный ввод. Делитель равен нулю.");
            n = n % m;
            return n;
        }
    }
}
