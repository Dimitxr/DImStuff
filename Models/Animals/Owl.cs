using System;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        private const double Modifer = 0.25;
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override string ProduceSound()
        => "Hoot Hoot";

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
            => $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
    }
}
