using dotnet_01.Ej_03.taskManager.controllers.mappers;
using dotnet_01.Ej_03.taskManager.mapper;
using dotnet_01.Ej_03.taskManager.tasks;
using dotnet_01.Ej_03.taskManager.views;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.controllers
{
    internal class TaskController
    {
        internal TaskRepository repository;
        internal TaskView view;

        private Mapper mapper;

        internal TaskController(TaskRepository repository, TaskView view)
        {
            this.repository = repository;
            this.view = view;
            mapper = new MapperImpl();
        }

        void DisplayList()
        {
            List<TaskDisplayDTO> taskDisplayDTOs = new();

            foreach (var taskEntity in repository.GetAll()) {
                taskDisplayDTOs.Add(mapper.toTaskDisplayDTO(taskEntity));
            }

            view.DisplayList(taskDisplayDTOs);
        }

        void DisplayDetails()
        {
            int id = view.AskId();
            TaskEntity taskEntity = repository.Consult(id);

            if (taskEntity == null)
            {
                Console.WriteLine($"== Task {id} doesn't exist!");
                return;
            }

            view.DisplayDetails(mapper.toTaskDisplayDTO(taskEntity));
        }


        void Create() => repository.Add(mapper.toTaskEntity(view.AskDetails()));

        void Delete()
        {
            int id = view.AskId();
            TaskEntity taskEntity = repository.Consult(id);

            if (taskEntity == null)
            {
                Console.WriteLine($"== Task {id} doesn't exist!");
                return;
            }

            repository.Remove(taskEntity);
        }

        void Update()  
        {
            int id = view.AskId();
            TaskEntity taskEntity = repository.Consult(id);

            if (taskEntity == null) {
                Console.WriteLine($"== Task {id} doesn't exist!");
                return;
            }

            repository.Update(taskEntity, mapper.toTaskEntity(view.AskToUpdate(id)));
        }

        void ChangeState()
        {
            int id = view.AskId();
            TaskEntity taskEntity = repository.Consult(id);

            if (taskEntity == null)
            {
                Console.WriteLine($"== Task {id} doesn't exist!");
                return;
            }

            repository.ChangeState(taskEntity);
        }

        internal void Run()
        {
            bool exit = false;

            while (!exit)
            {
                TaskOption menuOption = view.AskMenuOption();

                switch (menuOption)
                {
                    case TaskOption.CreateTask: Create(); break;
                    case TaskOption.DeleteTask: Delete(); break;
                    case TaskOption.UpdateTask: Update(); break;
                    case TaskOption.ChangeState: ChangeState(); break;
                    case TaskOption.TaskDetails: DisplayDetails(); break;
                    case TaskOption.AllTasksDetails: DisplayList(); break;
                    case TaskOption.Exit: exit = true; break;
                }
            }
        }
    }
}
