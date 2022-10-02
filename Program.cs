using System;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            Calculator calc = new Calculator("k", new Validate(), new Calculate()
            , new Sub(), new Sum(),new Multi(), new division(), new Odd(), new Even());
            calc.Loop();
        }

    }
}
