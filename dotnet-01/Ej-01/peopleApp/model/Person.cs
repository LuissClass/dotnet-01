using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_01.model

/*Representa a una persona y es inmutable.
Su constructor protege sus propias reglas. Si el nombre está vacío o la edad es negativa, lanza InvalidPersonException. Esto evita que exista una persona inválida.
 */
{
    internal class Person
    {
        private readonly string name;
        private readonly int age;

        public Person(string name, int age) 
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new InvalidPersonException("El nombre no puede estar vacio");
            }

            if (age < 0) 
            {
                throw new InvalidPersonException("La edad no puede ser negativa");
            }

            if (age > 118) 
            {
                throw new InvalidPersonException("La edad no puede ser superior al maximo registrado");
            }

            this.name = name;
            this.age = age;
        }

        public string Name => name;
        public int Age => age;
    }
}
