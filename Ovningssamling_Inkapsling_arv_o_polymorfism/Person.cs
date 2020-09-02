using System;
using System.Collections.Generic;
using System.Text;

// TODO add comments
/// <summary>
/// 
/// </summary>
namespace OvningssamlingInkapslingArvOchPolymorfism
{
    public class Person
    {
        #region Properties
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
                if ( value.Length >= 3 && value.Length <= 15 )
                {
                    lName = value; 
                }
                else
                {
                    throw new System.ArgumentException("First name should contain between 3 and 15 letters!");
                }
            }
        }

        public double Height { get; set; }
        public double Weight { get; set; }

        #endregion

        #region Constructors
        public Person()
        {

        }
        #endregion
    }


    /* TODO: Skapa en klass Person och ge den följande privata attribut:
    age, fName, lName, height, weight
    Skapa publika properties med get och set som hämtar eller sätter tilldelad variabel.
    Instansiera en person i program.cs , kommer du direkt åt variablerna?
    Implementera validering i de skapade properties:
    ● Age kan bara tilldelas ett värde större än 0.
    ● FName är obligatorisk och får inte vara mindre än 2 tecken eller längre än
    10 tecken.
    ● LName är obligatorisk och får inte vara mindre än 3 tecken eller större än 15
    tecken.
    Kasta ett undantag av typen ArgumentException i varje property om dess
    validering inte fullföljs, undantaget ska innehålla ett beskrivande
    meddelande.
    Se till att hantera undantagen i Program-klassen med en try-catch block.


    I PersonHandler , skriv en metod som skapar en person med angivna värden:
    public Person CreatePerson (int age , string fname ,
    string lname , double height , double weight )


    Fortsätt skapa metoder i PersonHandler för att kunna hantera samtliga
    operationer som man kan vilja göra med en Person .
     */
}
