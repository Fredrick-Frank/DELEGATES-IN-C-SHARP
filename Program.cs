using System;

namespace DelegateApp
{
    public delegate void MyDelegate(string msg);
    public class Program
    {
        public static void Main()
        {
            MyDelegate del = ClassA.MethodA; 
            del.Invoke("Helo World!");

            del = ClassB.MethodB;
            del("Hello World");

            del = (string msg) => Console.WriteLine("Called lamba expression: " + msg);
            del("Hello World");
        }
    }
    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }
    public class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}