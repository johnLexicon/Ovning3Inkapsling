using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    /// <summary>
    /// Prints to and reads from Console
    /// </summary>
    public class ConsoleUI : IUI
    {
        /// <summary>
        /// Read input from Console
        /// </summary>
        /// <returns>User input</returns>
        public string GetInput()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Prints string to Console
        /// </summary>
        /// <param name="message">string to print</param>
        public void Print(string message)
        {
            Console.Write(message);
        }

        /// <summary>
        /// Prints string to Console ending with line break
        /// </summary>
        /// <param name="message">string to print</param>
        public void PrintLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
