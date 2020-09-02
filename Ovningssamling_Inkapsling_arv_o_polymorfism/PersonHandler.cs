using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    public static class PersonHandler
    {
        public static void SetAge(Person pers, int age) 
        {
            pers.Age = age;
        }
    }

    /*
    TODO: För att inkapsla Person-objekten ytterligare skall vi skapa klassen PersonHandler -
    en klass vars syfte är att skapa och hantera dina Person-objekt.
    I PersonHandler -klassen skapa metoden:
    public void SetAge(Person pers, int age)
    Använd den inskickade personens Age property för att sätta personens age-attribut
    via SetAge-metoden . Istället för att enbart använda en property har vi nu
    abstraherat med två lager.
     */
}
