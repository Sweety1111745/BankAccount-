using System;

namespace BankAccountApp
{
    class Program
    {
        // Атрибуты класса (поля)
        public string Наименование { get; set; }
        public int НомерСчета { get; set; }
        public double Сумма { get; set; }

        // Конструктор класса
        public Program(string наименование, int номерСчета, double сумма)
        {
            Наименование = наименование;
            НомерСчета = номерСчета;
            Сумма = сумма;
        }

        // Метод для вывода информации о счете
        public void ВывестиИнформацию()
        {
            Console.WriteLine($"Наименование: {Наименование}");
            Console.WriteLine($"Номер счета: {НомерСчета}");
            Console.WriteLine($"Сумма: {Сумма}");
        }

        // Точка входа в программу
        static void Main(string[] args)
        {
            // Создание объекта класса Program (вместо отдельного класса Счет)
            Program мойСчет = new Program("Основной счет", 123456789, 1500.75);

            // Вывод информации о счете
            мойСчет.ВывестиИнформацию();

            Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
        }
    }
}