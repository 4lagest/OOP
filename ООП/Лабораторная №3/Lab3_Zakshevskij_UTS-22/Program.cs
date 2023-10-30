using System;
using System.Text;

namespace Lab3
{
    class Programm
    {
        public class Worker
        {
            private string m_surname = "";
            public string surname
            {
                set
                {
                    if ((value != ""))
                    {
                        m_surname = value;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                get { return m_surname; }
            }
            private string m_name = "123";
            public string name
            {
                set
                {
                    if ((value != ""))
                    {
                        m_name = value;
                    }
                }
                get { return m_name; }
            }
            private string m_patronymic = "";
            public string patronymic
            {
                set
                {
                    if ((value != ""))
                    {
                        m_patronymic += value;
                    }
                }
                get { return m_patronymic; }
            }
            private string m_jobrang = "";
            public string jobrang
            {
                set
                {
                    if ((value != ""))
                    {
                        m_jobrang += value;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                get { return m_jobrang; }
            }
            private int m_salary;
            public int salary
            {
                set
                {
                    if (value >= 0)
                    {
                        m_salary = value;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                get { return m_salary; }
            }
            private int m_year;
            public int year
            {
                set
                {
                    if ((value >= 2000) && (value <= 2022))
                        m_year = value;
                    else
                    {
                        throw new Exception();
                    }
                }
                get { return m_year; }
            }
            public Worker(string s, string n, string p, string j, string sal, string y)
            {
                try
                {
                    surname = s;
                    name = n;
                    patronymic = p;
                    jobrang = j;
                    salary = int.Parse(sal);
                    year = int.Parse(y);
                }
                catch(Exception)
                {
                    Console.WriteLine("Некорректный ввод. Повторите действие, позязь");
                }

            }
        }
        public static void PrintArrWorker(Worker[] ArrWorker)
        {
            Console.Clear();
            for (int i = 0; i<ArrWorker.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}\n\tДолжность: {3}\n\tЗарплата: {4}\n\tГод: {5}", ArrWorker[i].surname, ArrWorker[i].name[0], 
                    ArrWorker[i].patronymic[0], ArrWorker[i].jobrang, ArrWorker[i].salary, ArrWorker[i].year);
            }
        }
        public static void PrintWorker(Worker ArrWorker)
        {
            Console.WriteLine("{0} {1} {2}\n\tДолжность: {3}\n\tЗарплата: {4}\n\tГод: {5}", ArrWorker.surname, ArrWorker.name[0],
                ArrWorker.patronymic[0], ArrWorker.jobrang, ArrWorker.salary, ArrWorker.year);
        }
        public static int CorrectInt(string b)
        {

            int a;
            do
            {
                if (int.TryParse(b, out a))
                {
                    break;
                }
                Console.WriteLine("Число должно быть целым и положительным");
                b = Console.ReadLine();
            } while (true);
            if (a < 0)
            {
                a = a * -1;
            }
            return a;
        }
        public static int Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Worker[] ArrWorker = new Worker[10];
            ArrWorker[0] = new Worker("Иванов", "Иван", "Иванович", "Продавец", "20000", "2018");
            ArrWorker[1] = new Worker("Бобков", "Влад", "Сишарпович", "Программист", "120000", "2016");
            ArrWorker[2] = new Worker("Хрустов", "Дима", "Олегович", "Маркетолог", "80000", "2020");
            ArrWorker[3] = new Worker("Прикольный", "Прикол", "Приколыч", "Комик", "210500", "2015");
            ArrWorker[4] = new Worker("Теслов", "Сергей", "СанФранцискович", "ДезигнерФромСанФрансисько", "150000", "2016");
            ArrWorker[5] = new Worker("Хрусталёв", "Дима", "Олегович", "Маркетолог", "85000", "2020");
            ArrWorker[6] = new Worker("Закшевский", "Родион", "Викторович", "Прогер-бомж за 3 копейки", "0", "2022");
            ArrWorker[7] = new Worker("Кабанов", "Алексей", "Владимирович", "Программист", "130000", "2014");
            ArrWorker[8] = new Worker("Кабанов", "Алексей", "Владимирович", "Дизайнер", "50000", "2021");
            ArrWorker[9] = new Worker("Мудаков", "Мудила", "Идиотович", "Манагер", "100000", "2020");
            PrintArrWorker(ArrWorker);
            Console.WriteLine("1. Сортировка по ЗП");
            Console.WriteLine("2. Сортировка по стажу");
            Console.WriteLine("3. Сортировка по должности");
            Console.WriteLine("0. Выход");
            string checkclient = Console.ReadLine();
            int client = CorrectInt(checkclient);
            do
            {
                while (true)
                {
                    if ((client == 1) || (client == 2) || (client == 3) || (client == 0))
                    {
                        break;
                    }
                    Console.WriteLine("Некорректный ввод, повторите его");
                    checkclient = Console.ReadLine();
                    client = CorrectInt(checkclient);
                }
                if (client == 1)
                {
                    Console.WriteLine("Введите ЗП: ");
                    string checkSalary = Console.ReadLine();
                    int salary = CorrectInt(checkSalary);
                    for (int i = 0; i < ArrWorker.Length; i++)
                    {
                        if (ArrWorker[i].salary >= salary)
                        {
                            PrintWorker(ArrWorker[i]);
                        }
                    }
                }
                if (client == 2)
                {
                    Console.WriteLine("Введите стаж: ");
                    string checkYear = Console.ReadLine();
                    int year = CorrectInt(checkYear);
                    for (int i = 0; i < ArrWorker.Length; i++)
                    {
                        if (2022 - ArrWorker[i].year >= year)
                        {
                            PrintWorker(ArrWorker[i]);
                        }
                    }
                }
                if (client == 3)
                {
                    Console.WriteLine("Введите должность: ");
                    string jobrang = Console.ReadLine();
                    for (int i = 0; i < ArrWorker.Length; i++)
                    {
                        if (ArrWorker[i].jobrang == jobrang)
                        {
                            PrintWorker(ArrWorker[i]);
                        }
                    }
                }
                Console.WriteLine("1. Сортировка по ЗП");
                Console.WriteLine("2. Сортировка по стажу");
                Console.WriteLine("3. Сортировка по должности");
                Console.WriteLine("0. Выход");
                checkclient = Console.ReadLine();
                client = CorrectInt(checkclient);
            } while (client != 0);
            return 0;
        }
    }
}
