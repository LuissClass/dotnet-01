using dotnet_01.Ej_02.controller;
using dotnet_01.Ej_02.counter.repository;
using dotnet_01.Ej_02.counter.view;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_02
{
    internal class Aplication02
    {
        internal static void Run()
        {   
            Controller controller = new Controller(new counter.view.ConsoleView(), new InMemoryRepository());

            while (true)
            {
                MenuOption option = controller.view.GetMenuOption();

                switch (option)
                {
                    case MenuOption.CreateCounter:
                        controller.CreateCounter();
                        break;
                    case MenuOption.DisplayCounter:
                        controller.DisplayCounter();
                        break;
                    case MenuOption.SumOne:
                        controller.SumOne();
                        break;
                    case MenuOption.Exit:
                        return;
                }
            }
        }
    }
}

