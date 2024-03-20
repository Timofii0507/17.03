using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Console.WriteLine("Same client code can work with different subclasses:");
            AbstractClass abstractClass = new ConcreteClass();
            abstractClass.TemplateMethod();
        }
    }
}