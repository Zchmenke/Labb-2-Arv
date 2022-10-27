using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_
{
    internal class Goat : Animal
    {
        //String Value shared between all goats and lambs.
        public string HornColor = "No horn color specified.";
        // Constructor for default values.
        public Goat()
        {

        }
        // Constructor recieving all attributes from "Animal" + goats class own Value "HornColor"
        public Goat(string _Name, string _Species, string _Gender, int _Age, string _Color, bool _Aggressiveness, int _HungerValue, string _AnimalSound, string _HornColor)
        : base(_Name, _Species, _Gender, _Age, _Color, _Aggressiveness, _HungerValue, _AnimalSound)
        {
            HornColor = _HornColor;
        }
    }
    // Two classes that inherits from "Goat class" rather than "Animal class"
    class WhiteLamb : Goat
    {
        // Constructor for default values.
        public WhiteLamb()
        {
        }

        public WhiteLamb(string _Name, string _Species, string _Gender, int _Age, string _Color, bool _Aggressiveness, int _HungerValue, string _AnimalSound, string _HornColor)
         : base(_Name, _Species, _Gender, _Age, _Color, _Aggressiveness, _HungerValue, _AnimalSound, _HornColor)
        {
        }
        public void LambJump()
        {
            if (HungerValue <= 1)
            {
                Console.WriteLine(Name + " Jumps around because it's soooooo hungry.");
            }
        }
    }
    class BlackLamb : Goat
    {
        // Constructor for default values.
        public BlackLamb()
        {
        }
        public BlackLamb(string _Name, string _Species, string _Gender, int _Age, string _Color, bool _Aggressiveness, int _HungerValue, string _AnimalSound, string _HornColor)
        : base(_Name, _Species, _Gender, _Age, _Color, _Aggressiveness, _HungerValue, _AnimalSound, _HornColor)
        {
        }
        public void LambAngry()
        {
            if (HungerValue <= 1)
            {
                Console.WriteLine(Name + " is very hungry, he stares at you with anger.");
            }

        }
        public void GoatAttack()
        {
            if (Aggressiveness == true)

            {
                Console.WriteLine(Name + " Is trying to attack you with its horns.");
            }
            else
            {
                Console.WriteLine(Name + " Seems like a nice goat.");
            }
        }
    }
}

