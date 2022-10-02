using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IOdd
    {
        public void odd();
    }
    class Odd : IOdd
    {
        public void odd()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("This is ODD ");
            Console.ResetColor();
        }
    }
    class Odd2 : IOdd
    {
        public void odd()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Class 2 => This is ODD ");
            Console.ResetColor();
        }
    }
}
