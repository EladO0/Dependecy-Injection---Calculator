using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Ivalidator
    {
        ConsoleColor valid();
        ConsoleColor invalid();
    }
    class Validate : Ivalidator
    {
        public ConsoleColor valid()
        {
            return ConsoleColor.Green;
        }
        public ConsoleColor invalid()
        {
            return ConsoleColor.Red;
        }
    }
    class Validate2 : Ivalidator
    {
        public ConsoleColor valid()
        {
            return ConsoleColor.Cyan;
        }
        public ConsoleColor invalid()
        {
            return ConsoleColor.Magenta;
        }
    }
}
