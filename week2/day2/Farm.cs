using System.Collections.Generic;

namespace someexersice
{
    class Animal
    {
        public int hunger;
        public int thirst;


        public Animal()
        {
            hunger = 50;
            thirst = 50;
        }

        public void eat()
        {
            this.hunger--;
        }

        public void drink()
        {
            this.thirst--;
        }

        public void play()
        {
            this.hunger--;
            this.thirst--;
        }

    }

    class Farm
    {
        public  List<Animal> AnimalList= new List<Animal>();

        public int slots=100;

        public void breed()
        {
            if (slots >= 0)
            {
                AnimalList.Add(new Animal());
            }
        }

        public void slaughter()
        {
            for (int i = 0; i < AnimalList.Count; i++)
            {
                if (AnimalList[i].hunger <= 0)
                {
                    AnimalList.Remove(AnimalList[i]);
                }
            }
        }



    }
}