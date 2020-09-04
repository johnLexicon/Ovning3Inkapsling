namespace Ovning3
{
    public class DivisionByZeroerror : UserError
    {
        public override string UEMessage()
        {
            return "You tried to divide by zero. This fired an error!";
        }
    }
}
