using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_02.counter.model
{
    internal class CounterDTO
    {
        internal int counter { get; } 

        internal CounterDTO(int initialCounter)
        {
            counter = initialCounter;
        }
    }
}
