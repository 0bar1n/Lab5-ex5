using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");// просим пользователя ввести данные
            string name = Console.ReadLine(); //ввод переменной строкового типа
            Console.WriteLine($"Привет {name}");//вывод переменной
            Console.ReadKey(); //остановка выполнения программы до тех пор, пока пользователь не нажмет клавишу, завершение работы
        }
    }
}