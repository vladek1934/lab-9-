﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CaclBrain
    {
        public double firstoperand;
        public double secondoperand;
        public double result;
        public char symbol;

        public double Plus()
        {
            result = firstoperand + secondoperand;
            return result;
        }
        public double Minus()
        {
            result = firstoperand - secondoperand;
            return result;
        }
        public double Multiply()
        {
            result = firstoperand * secondoperand;
            return result;
        }
        public double Divide()
        {
            result = firstoperand / secondoperand;
            return result;
        }
    }
}
