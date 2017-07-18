using System;

namespace Anymels
{
    class Program
    {
        static void Main(string[] args)
        {
            var Daintree = new Forest("Daintree Rainforest", "Australia");
            var Amazon = new Forest("Amazon Rainforest", "Brazil");

            var Kangaroo = new Animal
            {
                Fur = "Short",
                NumOfLegs = 3,
                Name = "Kangaroos"
            };

            var Lemur = new Animal
            {
                Fur = "Thick",
                NumOfLegs = 4,
                Name = "Lemurs"
            };

            Daintree.AddAnymels(Kangaroo);
            Amazon.AddAnymels(Lemur);

            Daintree.ListofAnymels();
            Amazon.ListofAnymels();
        }
    }
}
