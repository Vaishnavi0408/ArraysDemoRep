using System;

namespace MainAgruments
{
    abstract class Animal
    {
        public abstract void FoodHabits();
    }

    class Herbivorous : Animal
    {
        public override void FoodHabits()
        {
            Console.WriteLine("Herbivorous Animal eat only plant");
        }
    }

    class Carnivorous : Animal
    {
        public override void FoodHabits()
        {
            Console.WriteLine("Carnivorous Animal eat only meat");
        }

    }

    class Program
    {
        public void CallFoodHabit(Animal a)
        {
            
        }

        static void Main(string[] args)
        {
            int l = args.Length;
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine("Main param  "+ i+" " + args[i]);
            }
        }
    }
}
