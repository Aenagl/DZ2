using System;

namespace Tasks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

        }
        /*Задание 1.Выведите на экран информацию о каждом типе данных в виде:
        Тип данных – максимальное значение – минимальное значение*/
        static void Task1()
        {
            Console.WriteLine("Задание 1.");
            Console.WriteLine($"int – {int.MaxValue} – {int.MinValue}");
            Console.WriteLine($"long – {long.MaxValue} – {long.MinValue}");
            Console.WriteLine($"float – {float.MaxValue} – {float.MinValue}");
            Console.WriteLine($"double – {double.MaxValue} – {double.MinValue}");
            Console.WriteLine($"decimal – {decimal.MaxValue} – {decimal.MinValue}");
            Console.WriteLine($"byte – {byte.MaxValue} – {byte.MinValue}");
            Console.WriteLine($"sbyte – {sbyte.MaxValue} – {sbyte.MinValue}");
            Console.WriteLine($"short – {short.MaxValue} – {short.MinValue}");
            Console.WriteLine($"ushort – {ushort.MaxValue} – {ushort.MinValue}");
            //Console.WriteLine($"char - {(int)char.MaxValue} - {(int)char.MinValue}");
            Console.WriteLine($"bool – true – false");
        }
        /*Задание 2.Напишите программу, в которой принимаются данные пользователя в виде имени,
        города, возраста и PIN-кода. Далее сохраните все значения в соответствующей
        переменной, а затем распечатайте всю информацию в правильном формате.*/

        struct Data
        {
            /// <summary>
            /// Имя пользователя
            /// </summary>
            public string Name;
            /// <summary>
            /// Город пользователя
            /// </summary>
            public string City;
            /// <summary>
            /// Возраст пользователя
            /// </summary>
            public int Age;
            /// <summary>
            /// Пинкод пользователя
            /// </summary>
            public int PIN;
        }
        static void Task2()
        {
            Data personal_data = new Data();
            Console.WriteLine("Задание 2.");
            Console.Write("Введите своё имя:");
            personal_data.Name = Console.ReadLine();
            Console.Write("Введите свой город:");
            personal_data.City = Console.ReadLine();
            Console.Write("Введите свой возраст:");
            while (!Int32.TryParse(Console.ReadLine(), out personal_data.Age))
            {
                Console.Write("Введено некоректное значение. Пожалуйста, введите свой возраст: ");
            }
            Console.Write("Введите свой PIN-код:");
            while (!Int32.TryParse(Console.ReadLine(), out personal_data.PIN))
            {
                Console.Write("Введено некоректное значение. Пожалуйста, введите свой PIN-код: ");
            }
            Console.WriteLine($"Данные пользователя:\n Имя:{personal_data.Name}\n Город:{personal_data.City}\n Возраст:{personal_data.Age}\n PIN-код:{personal_data.PIN}");
        }
        //Задание 3.Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.
        static void Task3()
        {
            Console.WriteLine("Задание 3.");
        }
        //Задание 4.Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.

        static void Task4()
        {
            Console.WriteLine("Задание 4.");
            Console.Write("Введите строку:");
            string str = Console.ReadLine();
            Console.Write("Введите подстроку:");
            string sub_str = Console.ReadLine();
        }

        /*Задание 5.Определить, сколько бутылок виски беспошлинной торговли вам
        нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
        покрыла расходы на ваш отпуск.*/

        static void Task5()
        {
            Console.WriteLine("Задание 5.");
            Console.Write("Введите стандартную цену:");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите скидку в Duty Free:");
            int salePrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость отпуска:");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            double after_sale = normPrice * (1 - salePrice / 100.0);
            double bottle = normPrice - after_sale;
            int num_bottles = (int)(holidayPrice / bottle);
            Console.WriteLine($"Чтобы покрыть расходы на отпуск,нужно купить {num_bottles} бутылок");
        }
    

        /*Задание 6.Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
        рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель
        выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
        студента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с
        различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
        (процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
        выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде
        структуры: наименование типа напитка и процент спирта.*/

        struct Students
        {
            /// <summary>
            /// Фамилия
            /// </summary>
            public string Surname;
            /// <summary>
            /// Имя
            /// </summary>
            public string Name;
            /// <summary>
            /// Индентификатор
            /// </summary>
            public int ID;
            /// <summary>
            /// Дата рождения
            /// </summary>
            public DateTime Birth_Date;
            /// <summary>
            /// Категория алкоголизма a,b,c,d
            /// </summary>
            public char alcCategory;
            /// <summary>
            /// Объем выпитой жидкости 
            /// </summary>
            public double vdrank;
            /// Напиток
            public string chosen_dr;
        }
        struct Drinks
        {   /// <summary>
            /// Напиток
            /// </summary>
            public string drink;
            /// <summary>
            /// Процент спирта
            /// </summary>
            public double drink_per;
        }
    
        static void Task6()
        {
            Console.WriteLine("Задание 6.");
            Drinks beer = new Drinks()
            {
                drink = "Пиво",
                drink_per = 4
            };
            Drinks champagne = new Drinks()
            {
                drink = "Шампанское",
                drink_per = 10
            };
            Drinks vine = new Drinks()
            {
                drink = "Вино",
                drink_per = 7
            };
            Drinks vodka = new Drinks()
            {
                drink = "Водка",
                drink_per = 40
            };
            Drinks rum = new Drinks()
            {
                drink = "Ром",
                drink_per = 50
            };
            Students[] stud = new Students[5];
            stud[0] = new Students()
            {
                Surname = "Кокошкин",
                Name = "Андрей",
                ID = 1,
                Birth_Date = new DateTime(2005, 2, 19),
                alcCategory = 'a',
                vdrank = 1,
                chosen_dr = vodka.drink
            };
            stud[1] = new Students()
            {
                Surname = "Бублик",
                Name = "Иван",
                ID = 2,
                Birth_Date = new DateTime(2002, 1, 4),
                alcCategory = 'b',
                vdrank = 0.6,
                chosen_dr = vine.drink
            };
            stud[2] = new Students()
            {
                Surname = "Герасимов",
                Name = "Анатолий",
                ID = 3,
                Birth_Date = new DateTime(2001,1, 12),
                alcCategory = 'с',
                vdrank = 0.3,
                chosen_dr = champagne.drink
            };
            stud[3] = new Students()
            {
                Surname = "Парадавич",
                Name = "Семён",
                ID = 3,
                Birth_Date = new DateTime(1992, 3, 9),
                alcCategory = 'd',
                vdrank = 0.1,
                chosen_dr = rum.drink
            };
            stud[4] = new Students()
            {
                Surname = "Важнева",
                Name = "Екатерина",
                ID = 4,
                Birth_Date = new DateTime(2006, 8, 4),
                alcCategory = 'a',
                vdrank = 2,
                chosen_dr = beer.drink
            };
        }
    }
}