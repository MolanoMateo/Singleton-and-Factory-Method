using EjercicioSingleton;

class Program
{
    static void Main(string[] args)
    {
        // Obtener la instancia única del Singleton
        Singleton singleton1 = Singleton.Instance;
        Singleton singleton2 = Singleton.Instance;

        // Mostrar la información de las instancias
        Console.WriteLine("Singleton 1: " + singleton1.ToString());
        Console.WriteLine("Singleton 2: " + singleton2.ToString());
        Console.WriteLine("Value: " + singleton1.Value);
        // Comprobar si son la misma instancia
        Console.WriteLine("¿Son la misma instancia? " + (singleton1 == singleton2));

        //Modificar valor
        singleton1.IncrementValue();
        singleton1.IncrementValue();

        // mostrar nuevo valor
        Console.WriteLine("Value: " + singleton1.Value);
        Console.ReadKey();
    }

}



