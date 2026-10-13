using dotnet_01.Ej_01.controller;
using dotnet_01.Ej_01.model;
using dotnet_01.Ej_01.view;

namespace dotnet_01.Ej_01
/*Es la única clase que conoce todas las demás.
Su método run crea las implementaciones concretas, las conecta entre sí y ejecuta el bucle principal.
En cada vuelta pide una opción a la vista y llama al método correspondiente del controlador.
No contiene lógica de negocio ni de presentación.*/

/*REGLAS MVC: La vista nunca habla con el repositorio.
El controlador nunca imprime ni lee de consola.
El modelo no sabe quién lo usa.

 Application: todo*/
{
    internal class Application01
    {
        internal static void App01()
        {
            PersonRepository personRepository = new InMemoryPersonRepository();
            PeopleView view = new ConsolePeopleView();
            PeopleController peopleController = new(view, personRepository);

            while (true)
            {
                MenuOption option = view.AskMenuOption();

                if (option.Equals(MenuOption.ListPerson)) { 
                    peopleController.ListPeople();
                } else if (option.Equals(MenuOption.CreatePerson))
                {
                    peopleController.CreatePerson();
                } else if (option.Equals(MenuOption.Exit))
                {
                    break;
                }
            }
        }   
    }
}
