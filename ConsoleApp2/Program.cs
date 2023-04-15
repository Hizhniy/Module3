using System; // Подключенное пространство имен

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            string MyName = "Ilya";
            byte MyAge = 17;
            bool HaveIApet = true;
            float MyShoeSize = 41.5F;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.ReadKey();
        }
    }
}