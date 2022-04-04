using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        private const double Modifer = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string ProduceSound()
            => "ROAR!!!";

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
            => $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
