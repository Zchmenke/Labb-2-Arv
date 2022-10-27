using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_
{
    class Horse : Animal
    {
        bool IsFast=false;
        public Horse() 
        {
            
        }
        // Constructor that gets 
        public Horse(string _Name, string _Species, string _Gender, int _Age, string _Color, bool _Aggressiveness, int _HungerValue, string _AnimalSound, bool _IsFast)
        :base (_Name,_Species,_Gender, _Age, _Color, _Aggressiveness, _HungerValue,_AnimalSound)
        {
            IsFast = _IsFast;
        }

        // Horse Class own method checking if its a "fast horse" based on how old it is.
        public void FastHorse()
        {
            if (Age < 10) IsFast = true;
            else IsFast = false;

            if (IsFast == true) { Console.WriteLine(Name + " is very fast! look at it run!"); }
            else { Console.WriteLine(Name + " " + "is not fast, thats not very good for a " + Species + "!"); }
        }
    }
}
