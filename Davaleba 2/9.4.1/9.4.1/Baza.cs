﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4._1
{
    public class Baza
    {
        public double area(int a, int b, int c)
        {
            int perimeter = a + b + c;
            double p = perimeter / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
