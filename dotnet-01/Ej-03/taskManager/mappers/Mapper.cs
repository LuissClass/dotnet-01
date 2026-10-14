using dotnet_01.Ej_03.taskManager.tasks;
using System;
using System.Collections.Generic;
using System.Text;
using Task = dotnet_01.Ej_03.taskManager.tasks.TaskEntity;

namespace dotnet_01.Ej_03.taskManager.mapper
{
    internal class Mapper
    {
        internal Task toTaskItem(TaskDTO taskDTO)
        {
            return new Task(taskDTO.id, taskDTO.name, taskDTO.description, taskDTO.completed);
        }
    }
}
