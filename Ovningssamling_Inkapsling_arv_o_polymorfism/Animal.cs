using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    public abstract class Animal
    {
        #region properties /////////////////////////////////////////////////////////////////////////////

        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

        #endregion

        #region constructors ////////////////////////////////////////////////////////////////////////////

        public Animal()
        {

        }

        #endregion

        #region methods //////////////////////////////////////////////////////////////////////////////////

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}";
        }

        #endregion
    }
}
