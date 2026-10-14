
using dotnet_01.Ej_02.counter.model;
using dotnet_01.Ej_02.counter.repository;
using dotnet_01.Ej_02.counter.view;
using dotnet_01.Ej_02.model;

namespace dotnet_01.Ej_02.controller
{
    internal class Controller
    {
        internal ConsoleView view;
        internal InMemoryRepository repository;

        internal Controller(ConsoleView view, InMemoryRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }

        internal void CreateCounter()
        {
            CounterDTO counterData = view.CreateCounter();
            repository.CreateCounter(counterData);
        }

        internal void SumOne()
        {
            view.SumOne();
            Counter counter = repository.GetCounter();
            repository.SumOne(counter);
        }

        internal void DisplayCounter()
        {
            Counter counter = repository.GetCounter();
            view.DisplayCounter(toDisplayData(counter));
        }

        private CounterDisplayDTO toDisplayData(Counter counter)
        {
            CounterDisplayDTO counterDisplayData = new CounterDisplayDTO(counter.counter);
            return counterDisplayData;
        }
    }
}
