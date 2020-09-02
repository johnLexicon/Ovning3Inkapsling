using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    public abstract class Animal
    {
        #region properties /////////////////////////////////////////////////////////////////////////////
        public int Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        #endregion
    }

    /*
     Fyll klassen Animal med egenskaper ( properties) som alla djur bör ha. Tex namn, vikt, ålder.
3. Skapa en abstrakt metod som heter DoSound().
4. Skapa en konstruktor för att skapa ett Animal.
5. Skapa Subklasserna (ärver från Animal ): Horse , Dog , Hedgehog , Worm och Bird, Wolf .
6. Ge dessa minst en unik egenskap var. Vilken egenskap det är är inte det viktiga här.
Exempel Worm IsPoisonous, Hedgehog NrOfSpikes , Bird WingSpan osv.
7. Implementera så att DoSound() metoden skriver ut hur djuret låter..
8. Skapa nu följande tre klasser: Pelican , Flamingo och Swan . Dessa ska ärva från Bird .
9. Ge dessa minst en unik egenskap var.
10. Skapa gränssnittet IPerson med en metod deklaration Talk();
11. Skapa Klassen Wolfman som ärver från Wolf och implementerar IPerson gränssnittet.
12. Implementera Talk() som skriver ut vad Wolfman säger.
13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i
vilken klass bör vi lägga det?
14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
     */
}
