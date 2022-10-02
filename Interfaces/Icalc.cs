using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Icalc
    {
        public string calc(float a);
    }
    class CalculateInt : Icalc
    {
        public string calc(float a)
        {
            return a.ToString("n0");
        }
    }
    class CalculateFloat : Icalc
    {
        public string calc(float a)
        {
            return a.ToString("n2");
        }
    }
    class Calculate : Icalc
    {
        public string calc(float a)
        {
            return a.ToString();
        }
    }
}