using dotnet_01.Ej_02.counter.model;
using dotnet_01.Ej_02.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_02.counter.view
{
    internal interface View
    {
        CounterDTO CreateCounter();
        void DisplayCounter(CounterDisplayDTO counterDisplayData);
        void SumOne();
        MenuOption GetMenuOption();
    }
}
