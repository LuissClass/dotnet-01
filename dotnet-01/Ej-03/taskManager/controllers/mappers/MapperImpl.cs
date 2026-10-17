using dotnet_01.Ej_03.taskManager.mapper;
using dotnet_01.Ej_03.taskManager.tasks;
using dotnet_01.Ej_03.taskManager.views;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.controllers.mappers
{
    internal class MapperImpl : Mapper
    {
        public TaskDisplayDTO toTaskDisplayDTO(TaskEntity taskEntity)
        {
            return new TaskDisplayDTO(taskEntity.id, taskEntity.name, taskEntity.description, taskEntity.completed);
        }

        public TaskEntity toTaskEntity(TaskDisplayDTO taskDisplayDTO)
        {
            return new TaskEntity(taskDisplayDTO.id, taskDisplayDTO.name, taskDisplayDTO.description);
        }
    }
}
