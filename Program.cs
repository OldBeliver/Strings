using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string programLanguage;
            int experienceYears;
            int annualProfit;
            double minProfit;
            double maxProfit;
            
            double lowFactor = 0.9;
            double upperFactor = 1.1;
            
            Console.WriteLine($"Создавайте резюме быстро и легко");
            Console.WriteLine($"Наш конструктор поможет Вам рассказать работодателю важную для него информацию");
            Console.WriteLine();
            
            Console.Write($"Введите Ваше имя: ");
            name = Console.ReadLine();

            Console.Write($"Введите язык программирования: ");
            programLanguage = Console.ReadLine();

            Console.Write($"Введите опыт работы в годах: ");
            experienceYears = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Введите желаемый годовой доход (руб): ");
            annualProfit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Добрый день {name}, мы нашли несколько вакансий с требованием языка {programLanguage}, которые могут Вас заинтересовать");
            
            minProfit = annualProfit * lowFactor;
            maxProfit = annualProfit * upperFactor;
            Console.WriteLine($"Годовая зарплата в диапазоне {minProfit} - {maxProfit} рублей");
            Console.WriteLine($"Предложения уже высланы Вам на почту");
        }
    }
}
