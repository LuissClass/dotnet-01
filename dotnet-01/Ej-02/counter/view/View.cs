using dotnet_01.Ej_02.counter.model;
using dotnet_01.Ej_02.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_02.counter.view
{
    internal interface View
    {
        CounterData CreateCounter();
        void DisplayCounter(Counter counter);
        void SumOne();
        MenuOption GetMenuOption();
    }
}
