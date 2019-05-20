using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Infra.CrossCutting.Exceptions
{
    public class IncorrectPasswordException : PlurilingueException
    {
        public IncorrectPasswordException() : base("Incorrect password") { }
    }
}
