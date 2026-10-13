using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_01.Ej_01.model

/*Es el error del dominio y lleva el motivo del rechazo.
Uso excepciones y no códigos de retorno, como pide Clean Code.*/
{
    internal class InvalidPersonException : Exception
    {
        public InvalidPersonException(string message) : base(message) 
        { 
        }
    }
}
