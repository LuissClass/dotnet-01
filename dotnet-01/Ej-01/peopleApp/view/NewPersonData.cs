using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_01.view

/*Es un contenedor simple con los datos que escribió el usuario, aún sin validar.
Existe porque, en un MVC estricto, la vista no debe crear objetos del modelo. Los datos viajan crudos hasta el controlador y este construye la Person.*/
{
    internal class NewPersonData
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
