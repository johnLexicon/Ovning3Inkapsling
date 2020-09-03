using OvnSamlingInkapslArvOPolym;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    public class TextInputError : UserError
    {
        public override string UEMessage() 
        {
            return "You tried to use a text input in a numericonly field. This fired an error!";
        }
    }
}
