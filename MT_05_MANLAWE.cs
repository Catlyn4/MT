﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MT_05_MANLAWE.cs
{
    internal static class Program
    {
        private enum Operation
        {
            Unknown,

            Addition,

            Subtraction,

            Multiplication,

            Division,

            Exponentiation,

            Modulo
        };

        private static void Main()
        {

            // Ask user first number
            string stringFirstNumber;
            double firstNumber;

            do
            {
                Console.WriteLine("Type your first number :");
                stringFirstNumber = Console.ReadLine();
            } while (!double.TryParse(stringFirstNumber, out firstNumber));

            // Ask user second number
            string stringSecondNumber;
            double secondNumber;

            do
            {
                Console.WriteLine("Type your second number :");
                stringSecondNumber = Console.ReadLine();
            } while (!double.TryParse(stringSecondNumber, out secondNumber));

            string stringOperation;
            Operation operation;

            do
            {
                // Ask user operation to use
                Console.WriteLine("Enter the operation + (addition), - (subtraction), * (multiplication), / (division), ^ (exponent) or % (modulo) :");
                stringOperation = Console.ReadLine();

                // use for the string operation choice
                operation = ConvertStringChoiceToEnum(stringOperation);
            } while (operation == Operation.Unknown);

            // stock the result of the operation
            var result = DoSomethingByOperation(operation, firstNumber, secondNumber);

            Console.WriteLine();
            Console.WriteLine("Result of " + firstNumber + " " + stringOperation + " " + secondNumber + " = " + result + ".");
            Console.ReadKey();
        }

        private static Operation ConvertStringChoiceToEnum(string stringOperation)
        {
            // Convert string choice to enum
            switch (stringOperation)
            {
                case "+":
                case "addition":
                    return Operation.Addition;
                case "-":
                case "subtraction":
                    return Operation.Subtraction;
                case "*":
                case "multiplication":
                    return Operation.Multiplication;
                case "/":
                case "division":
                    return Operation.Division;
                case "^":
                case "exponent":
                    return Operation.Exponentiation;
                case "%":
                case "modulo":
                    return Operation.Modulo;
                default:
                    return Operation.Unknown;
            }
        }

        private static double DoSomethingByOperation(Operation operation, double firstNumber, double secondNumber)
        {
            // Do something depending on the operation choose
            switch (operation)
            {
                case Operation.Addition:
                    return firstNumber + secondNumber;

                case Operation.Subtraction:
                    return firstNumber - secondNumber;

                case Operation.Multiplication:
                    return firstNumber * secondNumber;

                case Operation.Division:
                    return firstNumber / secondNumber;

                case Operation.Exponentiation:
                    return Math.Pow(firstNumber, secondNumber);

                case Operation.Modulo:
                    return firstNumber % secondNumber;

                case Operation.Unknown:
                    return double.NaN;

                default:
                    return double.NaN;
            }
        }
    }
}
