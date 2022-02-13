using System;

namespace PolyMorphExm2
{
    sealed class Animal
    {
        public virtual void FoodHabits()
        {
            Console.WriteLine("Every Animal has different foodhabits");
        }
    }

    class Herbivorous : Animal
    {
        public sealed override void FoodHabits()
        {

            Console.WriteLine("Herbivorous Animal eat only plant");
        }

        public void HMethod()
        {
            Console.WriteLine("Herbivorous Method");
        }
    }

    class Cow : Herbivorous
    {
        public override void FoodHabits()
        {

            Console.WriteLine("Cow eat only plant");
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
        public void CallFoodHabits(Animal a)
        {
            a.FoodHabits();
            if (a.GetType() == typeof(Herbivorous))
            {
                Herbivorous h = (Herbivorous) a;
                h.HMethod();
            }
        }
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Herbivorous h = new Herbivorous();
            Carnivorous c = new Carnivorous();
            Cow cw = new Cow();
            Program p = new Program();
            p.CallFoodHabits(h);
            p.CallFoodHabits(c);
            p.CallFoodHabits(a);
            p.CallFoodHabits(cw);


        }
    }
}
