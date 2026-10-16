using dotnet_01.Ej_03.taskManager.exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.tasks
{
    internal class TaskEntity
    {
        internal int id { get; set; }
        internal string name { get; set; }
        internal string description { get; set; }
        internal bool completed { get; set; }

        internal TaskEntity(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(description))
            {
                throw new InvalidTaskException("Name and description cannot be null or empty.");
            }
            else if (name.Any(char.IsDigit) && description.Any(char.IsDigit)) {
                throw new InvalidTaskException("Name and description cannot contain digits.");
            }

            this.id = id;
            this.name = name;
            this.description = description;
        }

    }
}
