using dotnet_01.Ej_03.taskManager.tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.views
{
    internal interface TaskView
    {
        void DisplayTaskList(List<string> tasks);
        void DisplayTaskDetails(int idTask);
        TaskDTO AskTask();
        void RemoveTask(int idTask);
        TaskDTO UpdateTask();
    }
}
