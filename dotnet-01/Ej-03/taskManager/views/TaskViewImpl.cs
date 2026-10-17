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

            if (taskDisplayDTO.completed)
            {
                Console.WriteLine($"State: Completed");
            }
            else { 
                Console.WriteLine($"State: Pending");
            }
        }

        public void DisplayList(List<TaskDisplayDTO> tasks)
        {
            Console.WriteLine("== TASKS LIST DETAILS ==");
            foreach (var t in tasks)
            {
                string msg = $"Id: {t.id}, Name: {t.name}, Description: {t.description}, State: ";

                if (t.completed)
                {
                    msg += "Completed";
                }
                else { msg += "Pending"; }

                Console.WriteLine(msg);
            }
        }

        public int AskId()
        {
            bool exit = false;
            int id = 0;
            Console.WriteLine("== TASK ID ==");

            while (!exit)
            { 
                Console.WriteLine("Enter task id: ");

                try
                {
                    id = int.Parse(Console.ReadLine());
                    exit = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("== Wrong number format");
                }
            }
            return id;

        }

        public TaskDisplayDTO AskToUpdate(int id)
        {

            Console.WriteLine("== TASK UPDATE ==");

            bool exit = false;
            string? name = null;
            string? description = null;

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
                        if (name == null || description == null)
                        {
                            Console.WriteLine("Name and description cannot be empty!");
                        }
                        else { 
                            exit = true;
                        }
                        break;
                }
            }

            TaskDisplayDTO taskDisplayDTO = new(name, description);
            taskDisplayDTO.id = id;

            return taskDisplayDTO;
        }

        public TaskOption AskMenuOption()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("== MENU ==");
                Console.WriteLine("1. Create task");
                Console.WriteLine("2. Update task");
                Console.WriteLine("3. Delete task");
                Console.WriteLine("4. Display task");
                Console.WriteLine("5. Display all tasks");
                Console.WriteLine("6. Change state");
                Console.WriteLine("0. Exit");
                Console.WriteLine();

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        return TaskOption.CreateTask;
                    case "2":
                        return TaskOption.UpdateTask;
                    case "3":
                        return TaskOption.DeleteTask;
                    case "4":
                        return TaskOption.TaskDetails;
                    case "5":
                        return TaskOption.AllTasksDetails;
                    case "6":
                        return TaskOption.ChangeState;
                    case "0":
                        return TaskOption.Exit;
                    default:
                        Console.Write("Wrong option selected");
                        break;

                }
            }

            return new TaskOption();
        }
    }
}
