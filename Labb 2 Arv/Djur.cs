using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv_
{
    class Animal
    {
        // Declaring Properties in Animal class
        public string Name;
        public string Species;
        public string Gender;
        public int Age;
        public string Color;
        public bool Aggressiveness;
        public int HungerValue;
        public string AnimalSound;

        // Constructor to initilaze default values
        public Animal() : this("Name not found", "Species not found", "No Gender specified.", 00, "Color Not specified.", false, 00, "No sounds found")
        {
        }
        // Constructor with all "Base" Properties.
        public Animal(string _Name, string _Species, string _Gender, int _Age, string _Color, bool _Aggressiveness, int _HungerValue, string _AnimalSound)
        {
            Name = _Name;
            Species = _Species;
            Gender = _Gender;
            Age = _Age;
            Color = _Color;
            Aggressiveness = _Aggressiveness;
            HungerValue = _HungerValue;
            AnimalSound = _AnimalSound;
        }
        //Methods which all classes inherits.

        //Method that prints the properties of the Objects!
        public void PrintInfo()
        {
            Console.WriteLine("Name : {0} \nSpecies : {1} \nGender : {2} \nAge : {3} \nColor : {4}\n-------------", Name, Species, Gender, Age, Color);
        }

        //Method that prints out weather or not a animal is friendly, it randomizes between 6 strings in a list.
        public void IsAgrressive()
        {
            Random NotAggroAnswer = new Random();
            List<string> NotAggro = new List<string> { " Looks at you with anger, you should probably run.\n", " Looks like a very mad animal.\n", " Looks mad if i were you i would stay away from that animal.\n" };
            int NotAggroIndex = NotAggroAnswer.Next(NotAggro.Count);

            Random AggroAnswer = new Random();
            List<string> Aggro = new List<string>() { " Looks friendly, maybe it want back scratches?\n", " Looks calm and friendly.\n", " Looks at you with friendly eyes.\n" };
            int AggroIndex = NotAggroAnswer.Next(Aggro.Count);

            if (Aggressiveness == true) { Console.WriteLine(Name + NotAggro[NotAggroIndex]); }
            else { Console.WriteLine(Name + Aggro[AggroIndex]); }
        }

        // Method that prints different answers depending on age of the animal.
        public void IsOld()
        {
            if (Age >= 10) { Console.WriteLine("This is a very old animal! Maybe you should consider slaughter?"); }
            else if (Age < 10 && Age >= 7) { Console.WriteLine(Name + " " + "Is starting to get old but still has some fight in it."); }
            else { Console.WriteLine(Name + " " + "is still a pretty young animal."); }
        }

        //Method that tells you if the animal is hungry or not. Based on a random number.
        public void IsHungry()
        {
            Random Hunger = new Random();
            int HungerValue1 = Hunger.Next(0, 5);
            HungerValue = HungerValue1;
            bool loopbool = true;
            while (loopbool == true)
            {
                if (HungerValue < 5)
                {
                    Console.WriteLine(Name + " Takes another bite off food.");
                    HungerValue++;
                }
                else if (HungerValue == 5)
                {
                    Console.WriteLine(Name + " is full now, it does not want anymore food.");
                    loopbool = false;
                }
            }

        }

        //Method that writes Animals assigned sound.
        public void MakeSound()
        {

            Console.WriteLine(Name + " Goes : " + AnimalSound + "\n");
        }


    }



}

