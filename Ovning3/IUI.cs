﻿namespace Ovning3
{
    interface IUI
    {
        /// <summary>
        /// Reads input
        /// </summary>
        /// <returns>input</returns>
        string GetInput();

        /// <summary>
        /// Prints string
        /// </summary>
        /// <param name="message">string to print</param>
        void Print(string message);

        /// <summary>
        /// Prints string ending with line break
        /// </summary>
        /// <param name="message">string to print</param>
        void PrintLine(string message);
    }
}
