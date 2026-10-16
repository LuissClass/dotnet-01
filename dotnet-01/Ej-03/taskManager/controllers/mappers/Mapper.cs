using dotnet_01.Ej_03.taskManager.tasks;
using dotnet_01.Ej_03.taskManager.views;
using System;
using System.Collections.Generic;
using System.Text;
using Task = dotnet_01.Ej_03.taskManager.tasks.TaskEntity;

namespace dotnet_01.Ej_03.taskManager.mapper
{
    internal interface Mapper
    {
        TaskEntity toTaskEntity(TaskDisplayDTO taskDisplayDTO);
        TaskDisplayDTO toTaskDisplayDTO(TaskEntity taskEntity);
    }
}
