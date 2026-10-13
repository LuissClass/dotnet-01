using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_01.view

/*Es una enumeración con las opciones CreatePerson, ListPeople y Exit.
Es vocabulario de la vista. La interfaz del usuario puede cambiar sin tocar el controlador.*/
{
    internal enum MenuOption
    {
        CreatePerson,
        ListPerson,
        Exit

    }
}
