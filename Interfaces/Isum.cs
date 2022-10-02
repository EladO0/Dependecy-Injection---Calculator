using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Isum
    {
        public float sum(float a, float b); 
    }
    class Sum : Isum
    {
        public float sum(float a, float b)
        {
            return a + b;
        }
    }
    class Sum2 : Isum
    {
        public float sum(float a, float b)
        {
            Console.WriteLine("Sum2 => This is Injected!");
            return 2*a + b;
        }
    }
}
