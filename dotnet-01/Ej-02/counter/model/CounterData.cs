using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_02.counter.model
{
    internal class CounterData
    {
        internal int counter { get; } = 0;

        internal CounterData(int initialCounter)
        {
            counter = initialCounter;
        }
    }
}
