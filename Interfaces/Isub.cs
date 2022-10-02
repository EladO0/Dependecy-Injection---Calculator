using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Isub
    {
        public float sub(float a, float b);
    }
    class Sub : Isub
    {
        public float sub(float a, float b)
        {
            return a - b;
        }
    }
}
