using System; // Подключенное пространство имен

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            //string MyName = "Ilya";
            //byte MyAge = 17;
            //bool HaveIApet = true;
            //float MyShoeSize = 41.5F;

            Console.Write("Как тебя зовут? ");
            var Name = Console.ReadLine();
            Console.Write("Сколько тебе лет? ");
            byte Age = (byte)int.Parse(Console.ReadLine());
            Console.Write("Какой у тебя размер обуви? ");
            float ShoeSize = float.Parse(Console.ReadLine());
            Console.WriteLine();
            //Console.WriteLine("{0}, да ты уже большой!\nУ тебя нога - {1}! Хотя еще и молод: {2} лет", Name, ShoeSize, Age);
            Console.WriteLine(Name + ", да ты уже большой!\nУ тебя нога - "+ ShoeSize + "! Хотя еще и молод, годков всего " + Age);
            Console.WriteLine("\t\t-)");
            Console.ReadKey();
        }
    }
}