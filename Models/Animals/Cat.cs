using System;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animals
{
    public class Cat : Feline
    {
        private const double Modifer = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string ProduceSound()
            => "Meow";

        public override void EatFood(IFood food)
        {
            if (food is Vegetable || food is Meat)
            {
                this.Weight += Modifer * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString()
            => $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
