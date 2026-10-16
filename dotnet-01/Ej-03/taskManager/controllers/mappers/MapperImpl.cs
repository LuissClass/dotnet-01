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
            return new TaskDisplayDTO(taskEntity.name, taskEntity.description);
        }

        public TaskEntity toTaskEntity(TaskDisplayDTO taskDisplayDTO)
        {
            return new TaskEntity(taskDisplayDTO.name, taskDisplayDTO.description);
        }
    }
}
