using System;
using System.Collections.Generic;

namespace consolecalculator
{
    public class Calculator
    {

        public List<Calculation> Calculation = new List<Calculation>();

        //Calculator constructor - A constructor is automatically called when the class is instantiated

        public Calculator() { }
            

            public Calculator(double a, double b, string action)
            {

                CreateCalculation(a, b, action);






                //commenting out my code to try to get prof's working
                //Operations operation = new Operations();

                /*int result = 0;

                switch (action)
                {
                    case 1:
                        {
                            result = Operations.Addition(_input1, _input2);
                            break;
                        }
                    case 2:
                        {
                            result = operation.Subtraction(_input1, _input2);
                            break;
                        }
                    case 3:
                        {
                            result = operation.Multiplication(_input1, _input2);
                            break;
                        }
                    case 4:
                        {
                            result = operation.Division(_input1, _input2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter two valid numbers.");
                            break;
                        }
                }*/

            }


            public void CreateCalculation(double a, double b, string action)
            {
                Func<double, double, double> _operation;

                switch(action)
                {
                    case "sum":
                        _operation = Operations.Sum;
                        break;
                    case "difference":
                        _operation = Operations.Subtraction;
                        break;
                    case "multiplication":
                        _operation = Operations.Multiplication;
                        break;
                    case "division":
                        _operation = Operations.Division;
                        break;
                    default:
                        _operation = Operations.Unassigned;
                        break;
                }

                var _calculation = new Calculation(a, b, _operation);

                Calculation.Add(_calculation);
            }
    }
}
