using dotnet_01.Ej_01.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_01.view
/*Implementa PeopleView con la consola.
Es el único lugar donde existen Console.Write y Console.Read.
Solo presenta y captura. No valida reglas de negocio ni decide qué pasa después.*/
{
    internal class ConsolePeopleView : PeopleView
    {   
        public ConsolePeopleView() { }
        public MenuOption AskMenuOption()
        {
            Console.WriteLine("== MENU ==\n");
            Console.WriteLine("1. Create Person");
            Console.WriteLine("2. List People");
            Console.WriteLine("3. Exit");
            Console.WriteLine();

            int option = int.Parse(Console.ReadLine());

            return (MenuOption)(option - 1);
        }

        public NewPersonData AskNewPersonData()
        {
            Console.WriteLine("== CREATING A PERSON ==");
            NewPersonData newPersonData = new NewPersonData();

            Console.WriteLine("Person's name: ");
            newPersonData.Name = Console.ReadLine();
            Console.WriteLine("Age's name: ");
            newPersonData.Age = int.Parse(Console.ReadLine());

            return newPersonData;
        }

        public void ShowInvalidPerson(string reason)
        {
            Console.WriteLine("-x-x-x-x-x-");
            Console.WriteLine($"Invalid person: {reason}");
            Console.WriteLine("-x-x-x-x-x-");
        }

        public void ShowPeople(List<Person> people)
        {
            Console.WriteLine("==PEOPLE LIST==");
            foreach (Person person in people) 
            {
                Console.WriteLine($"\tPerson -> Name: {person.Name} Age: {person.Age}");
            }
            Console.WriteLine();
        }

        public void ShowPersonCreated(Person person)
        {
            Console.WriteLine($"Person -> Name: {person.Name} Age: {person.Age}");
            Console.WriteLine();
        }
    }
}
