using System;
using SingleCastDelegate;
using static SingleCastDelegate.Delegate;

class Program
{
    public static void Main(String[] args)
    {
        Operation obj = new Operation(Addition);
        Console.WriteLine("Addition of two number using delegate is:" + obj(51, 10));
    }
}