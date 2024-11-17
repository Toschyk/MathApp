using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    // Класс, содержащий методы для математических операций
    public class Calculator
    {
        // Метод для сложения двух чисел
        public int Add(int a, int b) => a + b;

        // Метод для вычитания двух чисел
        public int Subtract(int a, int b) => a - b;

        // Метод для умножения двух чисел
        public int Multiply(int a, int b) => a * b;

        // Метод для деления двух чисел
        public int Divide(int a, int b)
        {
            // Проверка на деление на ноль
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");

            return a / b;
        }
    }

    // Главный класс программы
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");

            // Считываем первое число от пользователя
            int a = int.Parse(Console.ReadLine());

            // Считываем второе число от пользователя
            int b = int.Parse(Console.ReadLine());

            // Создаем экземпляр калькулятора
            var calculator = new Calculator();

            // Вычисляем и выводим сумму чисел
            Console.WriteLine($"Сумма: {calculator.Add(a, b)}");

            // Задержка перед завершением программы, чтобы пользователь мог увидеть результат
            Console.WriteLine("Программа завершена. Нажмите любую клавишу для выхода.");
            Console.ReadLine();
        }
    }
}
