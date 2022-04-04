using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using WildFarm.Models.Animals;
using WildFarm.Models.Food;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IAnimal> animalsList = new List<IAnimal>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    string[] animalInfo = input.Split();
                    string[] foodInfo = Console.ReadLine().Split();

                    //Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}"
                    //Birds - "{Type} {Name} {Weight} {WingSize}"
                    //Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}"

                    string type = animalInfo[0];
                    string name = animalInfo[1];
                    double weight = double.Parse(animalInfo[2]);

                    IAnimal animal = null;

                    if (type == "Cat" || type == "Tiger")
                    {
                        string livingRegion = animalInfo[3];
                        string breed = animalInfo[4];
                        if (type == "Cat")
                        {
                            animal = new Cat(name, weight, livingRegion, breed);
                        }
                        else if (type == "Tiger")
                        {
                            animal = new Tiger(name, weight, livingRegion, breed);
                        }
                    }
                    else if (type == "Hen" || type == "Owl")
                    {
                        double wingSize = double.Parse(animalInfo[3]);
                        if (type == "Hen")
                        {
                            animal = new Hen(name, weight, wingSize);
                        }
                        else if (type == "Owl")
                        {
                            animal = new Owl(name, weight, wingSize);
                        }
                    }
                    else if (type == "Dog" || type == "Mouse")
                    {
                        string livingRegion = animalInfo[3];
                        if (type == "Dog")
                        {
                            animal = new Dog(name, weight, livingRegion);
                        }
                        else if (type == "Mouse")
                        {
                            animal = new Mouse(name, weight, livingRegion);
                        }
                    }

                    Console.WriteLine(animal.ProduceSound());
                    animalsList.Add(animal);

                    string foodType = foodInfo[0];
                    int quantity = int.Parse(foodInfo[1]);

                    IFood food = null;

                    if (foodType == "Vegetable")
                    {
                        food = new Vegetable(quantity);
                    }
                    else if (foodType == "Meat")
                    {
                        food = new Meat(quantity);
                    }
                    else if (foodType == "Seeds")
                    {
                        food = new Seeds(quantity);
                    }
                    else if (foodType == "Fruit")
                    {
                        food = new Fruit(quantity);
                    }

                    animal.EatFood(food);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animalsList)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
