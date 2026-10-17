using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.tasks
{
    internal interface TaskRepository
    {
        void Add(TaskEntity task);
        void Remove(TaskEntity task);
        TaskEntity Consult(int taskId);
        void Update(TaskEntity taskEntity, TaskEntity newTaskEntityData);
        void ChangeState(TaskEntity taskEntity);
        List<TaskEntity> GetAll();
    }
}
