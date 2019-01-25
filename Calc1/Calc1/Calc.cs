﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calc
    {
        private double firstNumber;
        private double secondNumber;


        public Calc()
        {
            firstNumber = 1;
            secondNumber = 1;
        }

        public Calc(double firstNumber, double secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public double GetFirstNumber()
        {
            return firstNumber;
        }


        public double SetFirstNumber(double firstNumber)
        {
            this.firstNumber = firstNumber;
            return this.firstNumber;
        }


        public double GetSecondNumber()
        {
            return secondNumber;
        }


        public double SetSecondNumber(double secondNumber)
        {
            this.secondNumber = secondNumber;
            return this.secondNumber;
        }

        public double GetAddition()
        {
            return Math.Round((firstNumber + secondNumber),2);
        }

        public double GetSubtraction()
        {
            return Math.Round((firstNumber - secondNumber),2);
        }

        public double GetMultiplication()
        {
            return Math.Round((firstNumber * secondNumber),2);
        }

        public double GetDivision()
        {
            try
            {
                return Math.Round((firstNumber / secondNumber),2);
            }
            catch (DivideByZeroException)
            {
                return (0);
            }
                        
            
        }

    }
}
