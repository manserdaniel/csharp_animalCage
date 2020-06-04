using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCage
{
    class Cage <T>
    {
        List<T> animals = new List<T>();

        public void addAnimal(T newAnimal)
        {
            animals.Add(newAnimal);
        }

        public void removeAnimal(T animalToRemove)
        {
            animals.Remove(animalToRemove);
        }
    }
}
