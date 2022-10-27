using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_
{
    internal class Cow : Animal
    {
        // Float value for Cows own method.
        public float MilkProd;

        // Constructor for default values.
        public Cow()
        {
        }
        // Constructor recieving all attributes from "Animal" + Cow class own Value "MilkProd" 
        public Cow(string _Name, string _Species, string _Gender, int _Age, string _Color, bool _Aggressiveness, int _HungerValue, string _AnimalSound, float _MilkProd)
         :base (_Name,_Species,_Gender,_Age,_Color,_Aggressiveness,_HungerValue,_AnimalSound)
        {
            MilkProd = _MilkProd;
        }

        // Method to see if cow needs to be milked (based on a random value created)
        public void MilkCow()
        {
            Random milk = new Random();
            int milkValue = milk.Next(1, 11);

            if (milkValue <= 6)
            {
                Console.WriteLine(Name + " Does not need to be milked.");
            }
            else
            {
                Console.WriteLine(Name + " Needs to be milked.");
            }
        }
    }
}
