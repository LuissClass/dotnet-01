using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_02.counter.view
{
    internal class CounterDisplayDTO
    {
        internal int counter { get; }

        internal CounterDisplayDTO(int initialCounter)
        {
            counter = initialCounter;
        }
    }
}
