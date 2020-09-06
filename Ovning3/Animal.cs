namespace Ovning3
{
    public abstract class Animal
    {
        private static IUI ui = new UI();

        protected Animal()
        {
        }


        #region properties **********************************************************************************

        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        internal static IUI Ui { get => ui; set => ui = value; }

        #endregion

        #region methods *************************************************************************************

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}";
        }

        #endregion
    }
}
