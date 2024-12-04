using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace Day4
{
    public class App
    {



        public void Run()
        {
            var availableAnimals = SeedAnimalList();

            Console.WriteLine("In the shelter we currently have:");
            //a.Hur många hundar(1 siffra)

            var amtOfDogs = availableAnimals.Count(a => a.AnimalType == AnimalType.Dog);
            Console.WriteLine($"\n{amtOfDogs} number of dogs.");


            //b.Äldsta djur(1 Animal)

            var oldestAnimal = availableAnimals.OrderBy(a => a.Age).Last();
            Console.WriteLine($"\nThe oldest animal is a {oldestAnimal.AnimalType} and is {oldestAnimal.Age}");

            //c.Vaccinerade djur(List)

            var vaccinatedAnimals = availableAnimals.Where(a => a.IsVaccinated).ToList();
            Console.WriteLine("\nThe animals that are vaccinated are:");
            foreach (var a in vaccinatedAnimals)
                Console.WriteLine(a.Name);


            //d. 4 ben över 3 år gamla(List)

            var fourLeggedAnimalsAboveThreeYears = availableAnimals.Where(a => a.AmtOfLegs == 4 && a.Age > 3).ToList();
            Console.WriteLine("\nThe animals that are above 3 years with 4 legs are:");
            foreach (var a in fourLeggedAnimalsAboveThreeYears)
                Console.WriteLine(a.Name);

            //e.Finns ett djur som heter Shadow(Bool)

            var answerE = availableAnimals.Any(a => a.Name == "Shadow");
            if (answerE)
                Console.WriteLine("\nThere is an animal that is named 'Shadow'.");
            else
                Console.WriteLine("\nThere are no animals named 'Shadow'");


            Console.ReadKey(true);
        }
        private List<Animal> SeedAnimalList()
        {
            return
                [
                new Animal
                {
                    Name = "Shadow",
                    AnimalType = AnimalType.Dog,
                    Age = 4,
                    AmtOfLegs = 4,
                    IsVaccinated = false
                },
                new Animal
                {
                    Name = "Tussen",
                    AnimalType = AnimalType.Dog,
                    Age = 11,
                    AmtOfLegs = 4,
                    IsVaccinated = true
                },
                new Animal
                {
                    Name = "Bella",
                    AnimalType = AnimalType.Cat,
                    Age = 3,
                    AmtOfLegs = 4,
                    IsVaccinated = true
                },
                new Animal
                {
                    Name = "Hoppsan",
                    AnimalType = AnimalType.Bunny,
                    Age = 2,
                    AmtOfLegs = 4,
                    IsVaccinated = false
                },
                new Animal
                {
                    Name = "Tweety",
                    AnimalType = AnimalType.Bird,
                    Age = 1,
                    AmtOfLegs = 2,
                    IsVaccinated = true
                },
                new Animal
                {
                    Name = "Speedy",
                    AnimalType = AnimalType.Turtle,
                    Age = 15,
                    AmtOfLegs = 4,
                    IsVaccinated = false
                },
                new Animal
                {
                    Name = "Whiskers",
                    AnimalType = AnimalType.Cat,
                    Age = 5,
                    AmtOfLegs = 4,
                    IsVaccinated = true
                },
                new Animal
                {
                    Name = "Fluffy",
                    AnimalType = AnimalType.Bunny,
                    Age = 3,
                    AmtOfLegs = 4,
                    IsVaccinated = true
                },
                new Animal
                {
                    Name = "Polly",
                    AnimalType = AnimalType.Bird,
                    Age = 2,
                    AmtOfLegs = 2,
                    IsVaccinated = false
                },
                new Animal
                {
                    Name = "Shelly",
                    AnimalType = AnimalType.Turtle,
                    Age = 20,
                    AmtOfLegs = 4,
                    IsVaccinated = true
                },
                new Animal
                {
                    Name = "Charlie",
                    AnimalType = AnimalType.Dog,
                    Age = 6,
                    AmtOfLegs = 4,
                    IsVaccinated = true
                },
                new Animal
                {
                    Name = "Mittens",
                    AnimalType = AnimalType.Cat,
                    Age = 7,
                    AmtOfLegs = 4,
                    IsVaccinated = false
                }
                ];
        }
    }
}
