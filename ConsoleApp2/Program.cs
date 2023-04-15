using System; // Подключенное пространство имен

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, {0}", name);
            Console.WriteLine("А вес?");
            string weight = Console.ReadLine();
            Console.WriteLine("Ого, целых {0}", weight);
            Console.WriteLine("А рост?");
            string height = Console.ReadLine();
            Console.WriteLine("Ничего себе! {0} см", height);
        }
    }
}