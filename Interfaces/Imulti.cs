using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Imulti
    {
        public float multi(float a, float b);
    }
    class Multi : Imulti
    {
        public float multi(float a, float b)
        {
            return a * b;
        }
    }
}
