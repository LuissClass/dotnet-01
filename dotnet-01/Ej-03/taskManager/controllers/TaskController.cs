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
                TaskDisplayDTO taskDisplayDTO = new(taskEntity.name, taskEntity.description);
                taskDisplayDTOs.Add(taskDisplayDTO);
            }

            view.DisplayList(taskDisplayDTOs);
        }

        void DisplayDetails() => view.DisplayDetails(mapper.toTaskDisplayDTO(repository.Consult(view.AskId())));


        void Create() => repository.Add(mapper.toTaskEntity(view.AskDetails()));

        void Delete() => repository.Remove(repository.Consult(view.AskId()));

        void Update() => repository.Update(mapper.toTaskEntity(view.AskToUpdate()));

        void MarkAsCompleted() => repository.MarkAsCompleted(view.AskId());
    }
}
