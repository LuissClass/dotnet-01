using dotnet_01.Ej_01.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_01.view

/*Define todo lo que el sistema necesita decirle al usuario o preguntarle, sin saber que existe una consola.
Sus operaciones son:
askMenuOption: devuelve un MenuOption.
askNewPersonData: devuelve un NewPersonData.
showPeople(people).
showPersonCreated(person).
showInvalidPerson(reason).*/
{
    internal interface PeopleView
    {
        MenuOption AskMenuOption();
        NewPersonData AskNewPersonData();
        void ShowPeople(List<Person> people);
        void ShowPersonCreated(Person person);
        void ShowInvalidPerson(String reason);
    }
}
