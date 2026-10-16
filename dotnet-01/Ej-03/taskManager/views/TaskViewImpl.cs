using dotnet_01.Ej_03.taskManager.views;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.tasks
{
    internal class TaskViewImpl : TaskView
    {
        public TaskDisplayDTO AskDetails()
        {
            Console.WriteLine("== TASK CREATION ==");
            Console.WriteLine("Enter task name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter task description: ");
            string description = Console.ReadLine();

            return new TaskDisplayDTO(name, description);
        }

        public void DisplayDetails(TaskDisplayDTO taskDisplayDTO)
        {
            Console.WriteLine("== TASK DETAILS ==");
            Console.WriteLine($"Id: {taskDisplayDTO.id}");
            Console.WriteLine($"Name: {taskDisplayDTO.name}");
            Console.WriteLine($"Description: {taskDisplayDTO.description}");
            Console.WriteLine($"Completed: {taskDisplayDTO.completed}");
        }

        public void DisplayList(List<TaskDisplayDTO> tasks)
        {
            Console.WriteLine("== TASKS LIST DETAILS ==");
            foreach (var t in tasks)
            {
                Console.WriteLine($"Id: {t.id}, Name: {t.name}, Description: {t.description}, Completed: {t.completed}");
            }
        }

        public int AskId()
        {
            Console.WriteLine("== REMOVE TASK ==");
            Console.WriteLine("Enter task id: ");
            int id = int.Parse(Console.ReadLine());
            return id;

        }

        public TaskDisplayDTO AskToUpdate()
        {
            Console.WriteLine("== TASK UPDATE ==");

            bool exit = false;
            string name = "";
            string description = "";

            while (!exit) {
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Description");
                Console.WriteLine("0. Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Enter task name: ");
                        name = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Enter task description: ");
                        description = Console.ReadLine();
                        break;
                    case "0":
                        exit = true;
                        break;
                }
            }

            return new TaskDisplayDTO(name, description);
        }

        public MenuOption AskMenuOption()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("== MENU ==");
                Console.WriteLine("1. Create task");
                Console.WriteLine("2. Update task");
                Console.WriteLine("3. Delete task");
                Console.WriteLine("4. Display task");
                Console.WriteLine("5. Display all tasks");
                Console.WriteLine("0. Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        return MenuOption.CreateTask;
                    case "2":
                        return MenuOption.UpdateTask;
                    case "3":
                        return MenuOption.DeleteTask;
                    case "4":
                        return MenuOption.TaskDetails;
                    case "5":
                        return MenuOption.AllTasksDetails;
                    case "0":
                        return MenuOption.Exit;
                    default:
                        Console.Write("Wrong option selected");
                        break;
                       
                }
            }
        }
    }
}
