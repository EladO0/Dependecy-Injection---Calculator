using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IEven
    {
        public void even();
    }
    class Even : IEven
    {
        public void even()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("This is Even ");
            Console.ResetColor();
        }
    }
    class Even2 : IEven
    {
        public void even()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Class 2 => This is Even ");
            Console.ResetColor();
        }
    }
}
