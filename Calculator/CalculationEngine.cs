﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculationEngine
    {
        public int DoMath(string stuffToCalculate)
        {
            var splitNumbers = stuffToCalculate.Split("+");
            int firstNumber = int.Parse(splitNumbers[0]);
            int secondNumber = int.Parse(splitNumbers[1]);

            return firstNumber + secondNumber;

            //another way could be 
            //var splitNumbers = stuffToCalculate.Split("+")
                //.Select(int.Parse).ToArray();
            //return splitNumbers[0] + splitNumbers[1]
;        }
    }
}