using System;

namespace anymels
{
    class Program
    {
        static void Main(string[] args)
        {
            var RainForest = new Forest("Daintree Rainforest", "Australia");

            var Kangaroo = new Animal
            {
                Fur = "Short",
                NumOfLegs = 3,
                Name = "Kangaroo"
            };

            var Lemur = new Animal
            {
                Fur = "Thick",
                NumOfLegs = 4,
                Name = "Lemur"
            };

            RainForest.AddAnymels(Kangaroo);
            RainForest.AddAnymels(Lemur);

            RainForest.ListofAnymels();
        }
    }
}
