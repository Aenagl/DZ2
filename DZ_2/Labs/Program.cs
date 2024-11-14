using System;

namespace Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taskl31();
            Taskl32();
            Taskd31();
        }
        /*Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского счета(текущий и сберегательный).
        Создать переменную типа перечисления, присвоить ей значение и вывести это значение на печать.*/
        enum BankAccTypes
        {
            текущий,
            сберегательный
        }
        static void Taskl31()
        {
            Console.WriteLine("Упражнение 3.1");
            BankAccTypes type1 = BankAccTypes.сберегательный;
            BankAccTypes type2 = BankAccTypes.текущий;
            Console.WriteLine($"Вид банковского счёта: {type1}");
            Console.WriteLine($"Вид банковского счёта: {type2}");
        }
        /*Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском
счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
значениями и напечатать результат.*/
        struct BankAccount
        {
            /// <summary>
            /// Номер счёта
            /// </summary>
            public int number;
            /// <summary>
            /// Тип счёта
            /// </summary>
            public string type;
            /// <summary>
            /// Баланс счёта
            /// </summary>
            public decimal balance;
        }
        static void Taskl32()
        {
            BankAccount Acc = new BankAccount();
            Console.WriteLine("\nУпражнение 3.2");
            Console.Write("Введите номер счёта: ");
            while (!Int32.TryParse(Console.ReadLine(), out Acc.number))
            {
                Console.Write("Введено некоректное значение. Пожалуйста, введите номер счёта: ");
            }
            Console.Write("Введите тип счёта (сберегательный/текущий): ");
            Acc.type = Console.ReadLine();
            while ((!Acc.type.Equals("сберегательный")) && (!Acc.type.Equals("текущий")))
            {
                Console.Write("Введён некоректный тип. Пожалуйста, введите тип счёта (сберегательный/текущий): ");
                Acc.type = Console.ReadLine();
            }
            Console.Write("Введите баланс счёта: ");
            while (!Decimal.TryParse(Console.ReadLine(), out Acc.balance))
            {
                Console.Write("Введено некоректное значение. Пожалуйста, введите баланс счёта: ");
            }
            Console.WriteLine($"\nИнформация о банковском счёте:\n Номер счёта: {Acc.number};\n Тип счёта: {Acc.type};\n Баланс счёта: {Acc.balance}.\n");
        }

        /*Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
        структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
        распечатать.*/
        enum Uni
        {
            КФУ,
            КАИ,
            КХТИ
        }
        struct Employee
        {
            /// <summary>
            /// Имя работника
            /// </summary>
            public string Name;
            /// <summary>
            /// Университет
            /// </summary>
            public Uni University;
            /// <summary>
            /// Выводит информацию на экран
            /// </summary>
            public void Print()
            {
                Console.WriteLine($"Информация о работнике:\n Имя:{Name}\n ВУЗ:{University}");
            }
        }
        static void Taskd31()
        {
            Console.WriteLine("Домашнее задание 3.1");
            Employee employee = new Employee()
            {
                Name = "Руслана",
                University = Uni.КФУ
            };
            employee.Print();
        }
    }
}
