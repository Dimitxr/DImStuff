using WildFarm.Models.Food;

namespace WildFarm.Models.Animals
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public string ProduceSound();

        void EatFood(IFood food);
        

    }
}

