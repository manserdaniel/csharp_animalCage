using System;

namespace AnimalCage
{
    class Program
    {
        static void Main(string[] args)
        {
            Monkey monkey = new Monkey("chichi");
            Monkey monkey1 = new Monkey("chacha");


            Tiger tiger = new Tiger("lion");
            Tiger tiger1 = new Tiger("lionTiger");

            Cage<Monkey> monkeyCage = new Cage<Monkey>();
            Cage<Tiger> tigerCage = new Cage<Tiger>();

            monkeyCage.addAnimal(monkey);
            monkeyCage.addAnimal(monkey1);
            monkeyCage.removeAnimal(monkey);

            tigerCage.addAnimal(tiger);
            tigerCage.addAnimal(tiger1);
            tigerCage.removeAnimal(tiger);

        }
    }
}
