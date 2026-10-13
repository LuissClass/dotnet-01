using dotnet_01.Ej_01.model;
using dotnet_01.Ej_01.view;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_01.controller

/*Orquesta los casos de uso con dos métodos: createPerson y listPeople.
createPerson pide los datos a la vista, construye la Person, la agrega al repositorio y le dice a la vista que muestre la confirmación. Si el modelo lanza InvalidPersonException, la captura y le pide a la vista que muestre el motivo.
listPeople obtiene todas las personas del repositorio y se las entrega a la vista.
Depende solo de las abstracciones PersonRepository y PeopleView, que recibe por constructor.*/
{
    internal class PeopleController
    {
        private readonly PeopleView view;
        private readonly PersonRepository personRepository;

        internal PeopleController(PeopleView view, PersonRepository personRepository)
        { 
            this.view = view;
            this.personRepository = personRepository;
        }

        internal void CreatePerson() 
        {
            try
            {
                NewPersonData newPersonData = view.AskNewPersonData();
                Person person = new Person(newPersonData.Name, newPersonData.Age);
                personRepository.Add(person);
                view.ShowPersonCreated(person);
            }
            catch (InvalidPersonException ipe) 
            {
                view.ShowInvalidPerson(ipe.Message);
            }
        }

        internal void ListPeople()
        { 
            view.ShowPeople(personRepository.GetAll());
        }
    }
}
