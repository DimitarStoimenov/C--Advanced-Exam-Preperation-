using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        public List<Animal> Animals = new List<Animal>();

        private string name;
        private int capacity;

        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
         
        public string AddAnimal(Animal animal)
        {
            if (Animals.Count < capacity)
            {


                if (animal.Species == " " || animal.Species == null)
                {
                    return "Invalid animal species.";

                }
                if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
                {
                    return "Invalid animal diet.";
                }
                if (Animals.Capacity >= capacity)
                {
                    return "The zoo is full.";

                }
               
                

            }
            Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";

        }
        public int RemoveAnimals(string species)
        {
            int count = 0;
            foreach (var item in Animals)
            {
                if (item.Species == species)
                {
                    count++;
                }
            }
            Animals.RemoveAll(animal => animal.Species == species);
            return count;
            
            
 
        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animalByDiet = new List<Animal>();
            foreach (var item in Animals)
            {
                if (item.Diet == diet)
                {
                    animalByDiet.Add(item);
                }
            }

            return animalByDiet;
        }

       public Animal GetAnimalByWeight(double weight)
        {
            
            return Animals.First(animal => animal.Weight == weight);
            
        }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = 0;
            foreach (var item in Animals)
            {
                if (item.Length >= minimumLength && item.Length <= maximumLength)
                {
                    count++;
                }
            }

            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";


        }
    }
}
