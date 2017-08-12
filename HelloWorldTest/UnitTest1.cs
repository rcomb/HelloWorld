using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HelloWorldTest
{
    [TestClass]
    public class HelloWorld
    {
        [TestMethod]
        public static void PrintMessage()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
