using System;
using System.Collections.Generic;
using System.Text;
namespace Labb_2_Arv_
{
    // Henrik Rydén SUT22
    //Labb 2 Inheritance.
    internal class Program
    {
        static void Main(string[] args)
        {
            Menue();
        }

        public static void Menue()
        {
            // Animals.
            //A "Horse" created from Horse Class.
            var Pelle = new Horse("Pelle", "Horse", "Male", 5, "Brown", false, 0, "Neigh Neigh!", true);

            //Goat and its Lambs (objects) from / Goat and lambs class.
            var Lennart = new Goat("Lennart", "Goat", "Male", 7, "Brown", true, 0, "Baaah!", "Black");
            var Bernard = new WhiteLamb("Bernard", "Goat / Lamb", "Male", 1, "White", true, 0, "baaaaaaaaah!", "gray");
            var Greta = new BlackLamb("Greta", "Doe / lamb", "Female", 2, "Black", false, 2, "baah!", "Black");

            // Cow object from cow class
            var Rosa = new Cow("Rosa", "Cow", "Female", 3, "White with black spots", false, 0, "MOOOOO!", 1034.34f);
          
            // Adding All the different animals to a list to iterate thourgh with methods.
            List<Animal> animalList = new List<Animal>();
            animalList.Add(Pelle);animalList.Add(Lennart);animalList.Add(Bernard); animalList.Add(Greta);animalList.Add(Rosa);


            bool MenueBool = true;
            do
            {
                Console.WriteLine("[1] Show animals information.\n[2] Show the animals different sounds.\n[3] Show which animals are friendly.");
                int userChoice = (Int32.Parse(Console.ReadLine()));
                switch (userChoice)
                {
                    case 1:
                        foreach (var Animal in animalList)
                        {
                            Animal.PrintInfo();
                        }
                        break;

                    case 2:
                        foreach (var Animal in animalList)
                        {
                            Animal.MakeSound();
                        }
                        break;

                    case 3:
                        foreach (var Animal in animalList)
                        {
                            Animal.IsAgrressive();
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            while (MenueBool == true);
        }
    }
}
