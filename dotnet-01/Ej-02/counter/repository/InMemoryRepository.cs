using dotnet_01.Ej_02.counter.model;
using dotnet_01.Ej_02.model;
using dotnet_01.Ej_02.repositories;

namespace dotnet_01.Ej_02.counter.repository
{
    internal class InMemoryRepository : Repository
    {
        private Counter inMemoryCounter;

        internal InMemoryRepository() {
        }

        public void CreateCounter(CounterData counterData)
        {
            inMemoryCounter = new Counter(counterData.counter);
        }

        public void SumOne(Counter counter)
        {
            inMemoryCounter = new Counter(counter.counter + 1);
        }

        public Counter GetCounter()
        {
            return inMemoryCounter;
        }
    }
}
