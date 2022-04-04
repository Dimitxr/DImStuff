using System;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        private const double Modifer = 0.40;
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string ProduceSound()
            => "Woof!";

        public override void EatFood(IFood food)
        {
            if (food is Meat)
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
            => $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
