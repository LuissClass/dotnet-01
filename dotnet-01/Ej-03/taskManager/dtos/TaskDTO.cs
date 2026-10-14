using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.tasks
{
    internal record TaskDTO
    {
        internal int id;
        internal string name; 
        internal string description; 
        internal bool completed; 

        internal TaskDTO(int id, string name, string description, bool completed)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.completed = completed;
        }
    }
}
