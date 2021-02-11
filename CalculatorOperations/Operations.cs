using System;
using System.Collections.Generic;
using System.Text;

namespace consolecalculator
{
    public class Operations
    {

        public static Func<double, double, double> Sum = (a, b) => a + b;
        public static Func<double, double, double> Subtraction = (a, b) => a - b;
        public static Func<double, double, double> Multiplication = (a, b) => a * b;
        public static Func<double, double, double> Division = (a, b) => a / b;
        public static Func<double, double, double> Unassigned = (a, b) => 0;


        /*
        public Operations()
        {
            //commenting out my code to try to get prof's working
            int Addition(int _input1, int _input2)
            {
                int result = _input1 + _input2;
                return result;
            }

            public void int Subtraction(int _input1, int _input2)
            {
                int result = _input1 - _input2;
                return result;
            }

            public static int Multiplication(int _input1, int _input2)
            {
                int result = _input1 * _input2;
                return result;
            }

            public static int Division(int _input1, int _input2)
            {
                int result = _input1 / _input2;
                return result;
            }

        }
        */

    }
}
