using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using CalculatorTests;
using consolecalculator;
using consolecalculator.CalculatorOperations;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace CalculatorTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CalculatorTest()
        {
            Calculator _calculator = new Calculator();
            Assert.IsInstanceOfType(_calculator, typeof(Calculator));
        }

        [TestMethod]
        public void SumTest()
        {
            //arrange
            double _a = 1;
            double _b = 2;
            double _c;

            //act
            _c = Addition.Sum(_a, _b);

            //assert
            Assert.AreEqual(_c, 3);
        }

        [TestMethod]
        public void DifferenceTest()
        {
            //arrange
            double _a = 6;
            double _b = 4;
            double _c;

            //act
            _c = Subtract.Subtraction(_a, _b);

            //assert
            Assert.AreEqual(_c, 2);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            //arrange
            double _a = 5;
            double _b = 3;
            double _c;

            //act
            _c = Multiply.Multiplication(_a, _b);

            //assert
            Assert.AreEqual(_c, 15);
        }

        [TestMethod]
        public void DivisionTest()
        {
            //arrange
            double _a = 14;
            double _b = 7;
            double _c;

            //act
            _c = Divide.Division(_a, _b);

            //assert
            Assert.AreEqual(_c, 2);
        }

        [TestMethod]
        public void CalculationTest()
        {
            double _a = 1;
            double _b = 2;
            string _action = "multiplication";

            Calculator _calculator = new Calculator(_a, _b, _action);

            var _result = _calculator.Calculation[0].GetResult();

            _action = "division";

            _calculator.CreateCalculation(_a, _b, _action);

            _result = _calculator.Calculation[1].GetResult();

            _calculator.Calculation.ForEach(delegate (Calculation calculation)
            {
                Console.WriteLine(calculation.GetResult());
            });
        }
    }
}
