using dotnet_01.Ej_03.taskManager.tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.views
{
    internal interface TaskView
    {
        void DisplayList(List<TaskDisplayDTO> tasks);
        void DisplayDetails(TaskDisplayDTO taskDisplayDTO);
        TaskDisplayDTO AskDetails();
        int AskId();
        TaskDisplayDTO AskToUpdate();

        MenuOption AskMenuOption();
    }
}
