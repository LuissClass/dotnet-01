using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.tasks
{
    internal interface TaskRepository
    {
        void AddTask(TaskEntity task);
        void RemoveTask(TaskEntity task);
        TaskEntity ConsultTask(int taskId);
        void UpdateTask(TaskEntity taskEntity);
        void MarkTaskAsCompleted(int taskId);
    }
}
