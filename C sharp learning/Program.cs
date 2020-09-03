using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{

    interface ISomeInterface
    {
        int property { get; set; }
        void Print();
    }

    interface IDraw
    {
        void Draw();
    }

    class Test : ISomeInterface, IDraw
    {
        public int property { get; set; }
        public void Print()
        {
            Console.WriteLine("Hello, World");
        }
        public void Draw()
        {
            Console.WriteLine("Draw message");
        }
    }

        class Test2 : ISomeInterface
        {
            public int property { get; set; }
            public void Print()
            {
                Console.WriteLine("This is invoker thug life:)");
            }
        }

    
    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
           Test liora = new Test();
           Test2 liora1 = new Test2();
           liora.property = 12;
           liora.Print();
           liora.Draw();
           Console.WriteLine(liora.property);
           Console.WriteLine();

           liora1.property = 25;
           liora1.Print();
           
           Console.WriteLine(liora1.property);
            Console.ReadKey();
        }      
    }
}