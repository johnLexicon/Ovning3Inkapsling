namespace Ovning3
{
    interface IUI
    {
        string GetInput();
        void Print(string message);
        void PrintLine(string message = "");
    }
}
