using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._03
{
    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Виконання алгоритму A");
        }
    }
}
