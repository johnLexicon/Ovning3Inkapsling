using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    public class ConsoleUI : IUI
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Print(string message)
        {
            Console.Write(message);
        }

        public void PrintLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
