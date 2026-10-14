using dotnet_01.Ej_02.counter.model;
using dotnet_01.Ej_02.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_02.repositories
{
    internal interface Repository
    {
        void CreateCounter(CounterDTO counterData);
        void SumOne(Counter counter);
        Counter GetCounter();
    }
}
