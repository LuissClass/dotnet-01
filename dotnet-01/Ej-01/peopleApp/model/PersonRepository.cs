using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_01.model


/*Define qué necesita el sistema para guardar y recuperar personas, sin decir cómo.
Tiene dos operaciones: add(person) y getAll().
 */

{
    internal interface PersonRepository
    {
        void Add(Person person);
        List<Person> GetAll();  
    }
}


