using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_03.taskManager.exceptions
{
    internal class InvalidTaskException : Exception
    {
        internal InvalidTaskException(string message) : base(message)
        {
        }
    }
}
