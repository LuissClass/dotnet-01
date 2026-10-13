using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_01.model

/*Guarda las personas en memoria. El nombre dice la diferencia, no que sea una implementación.
Al devolver getAll entrega una copia de solo lectura, para que nadie modifique su estado interno.*/
{
    internal class InMemoryPersonRepository : PersonRepository
    {
        private readonly List<Person> people = new();

        public InMemoryPersonRepository() { }

        public void Add(Person person)
        {
            people.Add(person);
        }

        public List<Person> GetAll()
        {
            return people;
        }
    }
}
