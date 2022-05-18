using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegates
{
    internal class MultiDelegate
    {
        public delegate void OperationDelegate(int x, int y);
        public static void DelegateProblem()
        {
            OperationDelegate opt = Operation.Addition;

            opt += Operation.Subtraction;
            opt += Operation.Multiplication;
            opt += Operation.Square;
            opt(5,5);
            

        }
        public class Operation
        {
            public static void Addition(int x, int y)
            {
                Console.WriteLine("Addition of two number: " + (x + y));
            }
         
            public static void Subtraction(int x, int y)
            {
                Console.WriteLine("Subtraction of two number: " + (x - y));
            }
            public static void Multiplication(int x, int y)
            {
                Console.WriteLine("Multiplication of two number: " + (x * y));
            }
            public static void Square(int x, int y)
            {
                Console.WriteLine("Square: " + Math.Pow(x, y));
            }
        }
    }
}