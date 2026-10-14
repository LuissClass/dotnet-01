using dotnet_01.Ej_02.counter.model;
using dotnet_01.Ej_02.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_02.counter.view
{
    internal class ConsoleView : View
    {
        public CounterDTO CreateCounter()
        {
            Console.WriteLine("== NEW COUNTER ==");
            Console.Write("Enter initial value: ");
            var input = Console.ReadLine();
            return new CounterDTO(int.Parse(input));
        }

        public void DisplayCounter(CounterDisplayDTO counterDisplayData)
        {
            Console.WriteLine("== COUNTER ==");
            Console.WriteLine($"Counter value: {counterDisplayData.counter}\n");
        }

        public MenuOption GetMenuOption()
        {   
            Console.WriteLine("== MENU == ");
            Console.WriteLine("1. Create Counter");
            Console.WriteLine("2. Show Counter");
            Console.WriteLine("3. Sum One");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: \n");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    return MenuOption.CreateCounter;
                case "2":
                    return MenuOption.DisplayCounter;
                case "3":
                    return MenuOption.SumOne;
                case "4":
                    return MenuOption.Exit;
                default:
                    Console.WriteLine("Invalid option. Please try again.\n");
                    return GetMenuOption();
            }
        }

        public void SumOne()
        {
            Console.WriteLine("<< SUMMED ONE >>\n");
        }
    }
}
