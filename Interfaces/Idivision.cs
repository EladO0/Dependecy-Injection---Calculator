using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Idivision
    {
        public float divide(float a, float b);
    }
    class division : Idivision
    {
        public float divide(float a, float b)
        {
            return a / b;
        }
    }
}
