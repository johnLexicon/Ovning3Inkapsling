namespace Ovning3
{
    class ArrayInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a array input in a text only field. This fired an error!";
        }
    }
}