using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Calculator
    {
        public string k { get; set; }
        public bool flag { get; set; } = true;
        public char[] ch { get; set; } = { '+', '-', '*', '/' };
        public string text { get; set; } = "";
        public List<(char, int)> operands { get; set; } = new List<(char, int)>();
        public Ivalidator v { get; set; }
        public Isub sub { get; set; }
        public Isum sum { get; set; }
        public Imulti m { get; set; }
        public Idivision d { get; set; }
        public IOdd odd { get; set; }
        public IEven even { get; set; }
        public Icalc calc { get; set; }
        public Calculator(string k, Ivalidator v, Icalc calc, Isub sub, Isum sum, Imulti m, Idivision d
            , IOdd odd, IEven even)
        {
            this.k = k;
            this.v = v;
            this.calc = calc;
            this.sub = sub;
            this.sum = sum;
            this.m = m;
            this.d = d;
            this.odd = odd;
            this.even = even;
            Console.WriteLine("Enter " + k + " to Quit");
        }
        private static object _MessageLock = new object();

        public void Loop()
        {
            while (true)
            {
                Console.WriteLine("Enter An Expression:");
                text = Console.ReadLine();
                if (text == k)
                {
                    break;
                }
                GetOperator();
                if (!Check())
                {
                    continue;
                }
                WriteMessage(("Valid Expression:" + text), v.valid());
                solve(operands, text);
            }
        }
        public void WriteMessage(string message, ConsoleColor color)
        {
            lock (_MessageLock)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
        public bool solve(List<(char, int)> operands, string text)
        {
            float r = 0;
            if (operands.Count == 0) { r = float.Parse(text); }
            while (operands.Count != 0)
            {
                (char c, int i) = operands[0];
                float x = float.Parse(text.Substring(0, i).ToString());
                float y = float.Parse(text.Substring(i + 1).ToString());
                operands.RemoveAt(0);
                switch (c)
                {
                    case '+':
                        r = sum.sum(x, y);
                        break;
                    case '-':
                        r = sub.sub(x, y);
                        break;
                    case '*':
                        r = m.multi(x, y);
                        break;
                    case '/':
                        if (y == 0)
                        {
                            WriteMessage("Cannot divide by 0", v.invalid());
                            return false;
                        }
                        r = d.divide(x, y);
                        break;
                }
            }
            if (r % 2 == 0)
            {
                even.even();
            }
            else if((decimal)r == Math.Round((decimal)r, 0))
            {
                odd.odd();
            }

            WriteMessage(text + "=" + calc.calc(r), ConsoleColor.DarkCyan);
            return true;
        }

        public void GetOperator()
        {
            operands = new List<(char, int)>();
            for (int i = 0; i < text.Length; i++)
            {
                foreach (char c in ch)
                {
                    if (text[i] == c && i != 0)
                    {
                        operands.Add((c, i));
                    }
                }
            }
        }
        public bool Check()
        {
            if(operands.Count > 1 || text.Length == 0) { WriteMessage("Invalid Expression", v.invalid()); return false; }
            foreach((char c, int i) in operands)
            {
                if (i == 0 || i == text.Length)
                {
                    WriteMessage("Error 1: i:" + i + " " + text.Length, v.invalid());
                    return false;
                }
                foreach ((char c2, int i2) in operands)
                {
                    if (i2 != i && i2 - i < 2 && i2 - i > -2)
                    {
                        WriteMessage("Error 2: " + (i2 - i) + " " + i2 + " " + i, v.invalid());
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
