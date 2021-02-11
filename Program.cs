using System;

namespace consolecalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //profs code

            //calculator class instantiation into a calculator object
            Calculator _calculator = new Calculator();







            //commenting out my code to try to get prof's working
            /*
            Console.WriteLine("Choose which operation you wish to do:");
            Console.WriteLine("Press 1 for addition");
            Console.WriteLine("Press 2 for subtraction");
            Console.WriteLine("Press 3 for multiplication");
            Console.WriteLine("Press 4 for division");

            int action = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type in your first number:");

            int _input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number:");

            int _input2 = Convert.ToInt32(Console.ReadLine());
            */
            
            //int result = 0;

            /*switch(action)
            {
                case 1:
                    {
                        result = Addition(_input1, _input2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(_input1, _input2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(_input1, _input2);
                        break;
                    }
                case 4:
                    {
                        result = Division(_input1, _input2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please enter two valid numbers.");
                        break;
                    }
            }*/

            //Console.WriteLine("The result is: " + result);

        }


       /* public static int Addition(int _input1, int _input2)
        {
            int result = _input1 + _input2;
            return result;
        }


        public static int Subtraction(int _input1, int _input2)
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
        }*/

    }
}
