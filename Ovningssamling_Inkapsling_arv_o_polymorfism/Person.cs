using System;
using System.Collections.Generic;
using System.Text;

// TODO add comments
/// <summary>
/// 
/// </summary>
namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Person
    {
        private int age; //Field

        public int Age { get => age; set => age = value; } // Properties
    }

    /* TODO
     * Skapa en klass Person och ge den följande privata attribut:
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
     */
}
