using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.tasks.repository
{
    internal class TaskRepositoryImpl : TaskRepository
    {
        private List<TaskEntity> tasks;

        public TaskRepositoryImpl()
        {
            tasks = new List<TaskEntity>();
        }

        public void Add(TaskEntity task)
        {
            int i = tasks.Count;
            task.id = tasks.Count + 1;
            tasks.Add(task);
        }

        public TaskEntity Consult(int taskId) => tasks.Find(t => t.id == taskId);

        public List<TaskEntity> GetAll() => tasks;

        public void ChangeState(TaskEntity taskEntity)
        {
            taskEntity.completed = !taskEntity.completed;
        }

        public void Remove(TaskEntity task)
        { 
            tasks.Remove(task);

            for (int i=0; i < tasks.Count; i++) {
                tasks[i].id = i + 1;
            }
        }

        public void Update(TaskEntity taskEntity, TaskEntity newTaskEntityData)
        {
            taskEntity.name = newTaskEntityData.name;
            taskEntity.description = newTaskEntityData.description;
        }
    }
}
