using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.views
{
    internal record TaskDisplayDTO
    {
        internal int id { get; set; }
        internal string name { get; set; }
        internal string description { get; set; }
        internal bool completed { get; set; }

        internal TaskDisplayDTO(int id, string name, string description, bool completed)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.completed = completed;
        }
    }
}
