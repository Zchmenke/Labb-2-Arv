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

            // Animals.
            //A "Horse" created from Horse Class.
            var Pelle = new Horse("Pelle", "Horse", "Male", 5, "Brown", false, 0, "Neigh Neigh!", true);

            //Goat and its Lambs (objects) from / Goat and lambs class.
            var Lennart = new Goat("Lennart", "Goat", "Male", 7, "Brown", true, 0, "Baaah!", "Black");
            var Bernard = new WhiteLamb("Bernard", "Goat / Lamb", "Male", 1, "White", true, 0, "baaaaaaaaah!", "gray");
            var Greta = new BlackLamb("Greta", "Doe / lamb", "Female", 2, "Black", false, 2, "baah!", "Black");

            // Cow object from cow class
            var Rosa = new Cow("Rosa", "Cow", "Female", 3, "White with black spots", false, 0, "MOOOOO!", 1034.34f);

            //Sending all the objects of the different classes to menue method so the information can be used in a menu structure.
            Menue(Pelle, Lennart, Bernard, Greta, Rosa);
        }

        public static void Menue(Horse Pelle, Goat Lennart, WhiteLamb Bernard, BlackLamb Greta, Cow Rosa)
        {
            bool MenueBool = true;
            do
            {
                Console.WriteLine("[1] Show animals information.\n[2] Show the animals different sounds.\n[3] Show which animals are friendly.");
                int userChoice = (Int32.Parse(Console.ReadLine()));
                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        Pelle.PrintInfo(); Lennart.PrintInfo(); Bernard.PrintInfo(); Greta.PrintInfo(); Rosa.PrintInfo();
                        break;

                    case 2:
                        Console.Clear();
                        Pelle.MakeSound(); Lennart.MakeSound(); Bernard.MakeSound(); Greta.MakeSound(); Rosa.MakeSound();
                        break;

                    case 3:
                        Console.Clear();
                        Pelle.IsAgrressive(); Lennart.IsAgrressive(); Bernard.IsAgrressive(); Greta.IsAgrressive(); Rosa.IsAgrressive();
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            while (MenueBool == true);
        }
    }
}
