
using EjercicioFactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Que animal deseas escuchar?:");
            Console.WriteLine("1. Mamifero");
            Console.WriteLine("2. Pajaro");
            Console.WriteLine("3. Pez");
            Console.WriteLine("4. Ninguno");

            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Creator mammalCreator = new ConcreteCreatorMammal();
                IAnimals mammal = mammalCreator.FactoryMethod();
                Console.WriteLine("Mammal Sound: " + mammal.Sound());
            }
            else if (option == 2)
            {
                Creator birdCreator = new ConcreteCreatorBird();
                IAnimals bird = birdCreator.FactoryMethod();
                Console.WriteLine("Bird Sound: " + bird.Sound());
            }
            else if (option == 3)
            {
                Creator fishCreator = new ConcreteCreatorFish();
                IAnimals fish = fishCreator.FactoryMethod();
                Console.WriteLine("Fish Sound: " + fish.Sound());
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Opcion invalida. Prueba otra vez.");
            }
        }
    }
}


