using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_2_Virtual_Pet
{
    internal class Pets
    {
        private string Type;
        private string Color;
        private string Name;
        private string TypeOfFood;
        private int Age;
        private bool IsHungry = false;
        private bool NeedsCuddles = false;
        private bool NeedsToShit = false;


        public Pets(string type, string color, string name, string typeoffood, int age, bool ishungry, bool needscuddles, bool needstoshit) 
        {
            Type = type;
            Color = color;
            Name = name;
            TypeOfFood = typeoffood;
            Age = age;
            IsHungry = ishungry;
            NeedsCuddles = needscuddles;
            NeedsToShit = needstoshit;
        }


        public void printInfo()
        {
            Console.WriteLine($"Du genererte {Name}! Hen er en/et {Type}, er også {Color}, og er {Age} år gammel.Dette kjæledyret spiser {TypeOfFood}.");
        }


        public void feedPet()
        {
            if ( IsHungry == true ) 
            {
                Console.WriteLine($"Åh, {Name} ble kjempeglad for litt mat!");
            }
            else
            {
                Console.WriteLine($"{Name} var ikke sulten, prøv igjen senere.");
            }
        }
        public void cuddlePet()
        {
            if (NeedsCuddles == true )
            {
                Console.WriteLine($"Nå ble {Name} glad for litt kos");
            }
            else
            {
                Console.WriteLine($"{Name} vil ikke ha kos akkurat nå");
            }
        }
        public void needBathroom()
        {
            if (NeedsToShit == true)
            {
                Console.WriteLine($"Det var godt for {Name} å gå på do");
            }
            else
            {
                Console.WriteLine($"{Name} må ikke gå på do akkurat nå");
            }
        }

    }
}
