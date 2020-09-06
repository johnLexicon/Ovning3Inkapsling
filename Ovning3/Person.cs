using System.Text;

// TODO add/translate comments
/// <summary>
/// 
/// </summary>
namespace Ovning3
{
    public class Person
    {
        #region Properties ********************************************************************************
        private int age;

        public int Age
        {
            get { return age; }

            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new System.ArgumentException("Age must be higher than zero");
                }
            }
        }

        private string fName;

        /// <summary>
        /// FName är obligatorisk och får inte vara mindre än 2 tecken eller längre än 10 tecken.
        /// </summary>
        public string FName
        {
            get { return fName; }

            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    fName = value;
                }
                else
                {
                    throw new System.ArgumentException("First name should contain between two and ten letters!");
                }
            }
        }

        private string lName;

        /// <summary>
        /// LName är obligatorisk och får inte vara mindre än 3 tecken eller större än 15 tecken.  
        /// </summary>
        public string LName
        {
            get { return lName; }

            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    lName = value;
                }
                else
                {
                    throw new System.ArgumentException("Last name should contain between 3 and 15 letters!");
                }
            }
        }

        public int Height { get; set; }
        public double Weight { get; set; }

        #endregion

        #region Constructors ********************************************************************************

        // Constructor 1
        public Person(string firstName, string lastName)
        {
            FName = firstName;
            LName = lastName;
        }

        // Constructor 2
        public Person(string firstName, string lastName, int age) : this(firstName, lastName) // Calling constructor 1
        {
            Age = age;
        }

        // Constructor 3
        public Person(int age, string fname, string lname, int height, double weight) : this(fname, lname, age) // Calling constructor 2
        {
            Height = height;
            Weight = weight;
        }
        #endregion



        #region methods ********************************************************************************
        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.Append($"First name: {FName}, Last name: {LName}");

            if (Age > 0)
            {
                message.Append($", Age: {Age}");
            }

            if (Height > 0)
            {
                message.Append($", Height: {Height} cm");
            }

            if (Weight > 0)
            {
                message.Append($", Weight: {Weight} kilos");
            }

            return message.ToString();
        }
        #endregion
    }
}
