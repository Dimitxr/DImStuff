using WildFarm.Models.Food;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        private const double Modifer = 0.40;   
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override string ProduceSound()
        => "Cluck";

        public override void EatFood(IFood food)
        {
            this.Weight += Modifer * food.Quantity;
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
            => $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
    }
}
