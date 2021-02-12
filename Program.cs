using System;

namespace consolecalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //calculator class instantiation into a calculator object
            Calculator _calculator = new Calculator();


            /*Console.WriteLine("Choose which operation you wish to do:");
            Console.WriteLine("Please type 'sum' for addition");
            Console.WriteLine("Please type 'difference' for subtraction");
            Console.WriteLine("Please type 'multiplication' for multiplication");
            Console.WriteLine("Please type 'division' for division");

            string _action = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Type in your first number:");

            double _input1 = Convert.ToInt32(Console.ReadLine());
            Convert.ToDouble(_input1);

            Console.WriteLine("Enter your second number:");

            double _input2 = Convert.ToInt32(Console.ReadLine());
            Convert.ToDouble(_input2);
            */

            //test function
            /*
            var _result = _calculator.Calculation[0].GetResult();

            _calculator.CreateCalculation(_input1, _input2, _action);

            _result = _calculator.Calculation[1].GetResult();

            _calculator.Calculation.ForEach(delegate (Calculation calculation)
            {
                Console.WriteLine(calculation.GetResult());
            });
            //test function
            */

            //var _result = CreateCalculation(_input1, _input2);
            //Console.WriteLine(_calculation.GetResult());
        }

    }
}
