﻿namespace Ovning3
{
    class WrongNumberArgumentError : UserError
    {
        public override string UEMessage()
        {
            return "2 arguments needed, only 1 was provided. This fired an error!";
        }
    }
}