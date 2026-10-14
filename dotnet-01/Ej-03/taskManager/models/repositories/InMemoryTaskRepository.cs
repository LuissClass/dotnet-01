using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.tasks.repository
{
    internal class InMemoryTaskRepository : TaskRepository
    {
        private List<TaskEntity> tasks;

        public InMemoryTaskRepository()
        {
            tasks = new List<TaskEntity>();
        }

        public void AddTask(TaskEntity task) => tasks.Add(task);

        public TaskEntity ConsultTask(int taskId) => tasks.Find(t => t.id == taskId);

        public void MarkTaskAsCompleted(int taskId) => tasks.Find(t => t.id == taskId).completed = true;

        public void RemoveTask(TaskEntity task) => tasks.Remove(task);

        public void UpdateTask(TaskEntity taskEntity)
        {
            TaskEntity taskToChange = tasks.Find(t => t.id == taskEntity.id);
            taskToChange.id = taskEntity.id;
            taskToChange.name = taskEntity.name;
            taskToChange.description = taskEntity.description;
            taskToChange.completed = taskEntity.completed;
        }
    }
}
