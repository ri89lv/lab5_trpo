﻿using System;
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
            n = n * 2.54;
            return n;
        }

        
        {
            return (n % 2 == 0) ? true : false;
        }

        
        {
            int i; int max;
            int[] array = new int[] { 1, 5, 6, 9, 100};
            max = array[0];

            for (i = 0; i <= array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i]; 
            }

        }

       
        {
            n = n % m;
            return n;
        }
    }
}