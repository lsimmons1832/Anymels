using System;
using System.Collections.Generic;

namespace Anymels
{
    public class Forest
    {
         public string Name { get; }

        public string Location { get; }
        List<Animal> Animals {get; set;} = new List<Animal>(); 
    

        public Forest(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public void AddAnymels(Animal newAnimal)
        {
            Animals.Add(newAnimal);
        }

        public void ListofAnymels()
        {
            foreach (var animal in Animals)
            {
                Console.WriteLine($"{animal.Name} live in the {Name} and have {animal.NumOfLegs} and have {animal.Fur} fur");
            }
        }
    }
}
