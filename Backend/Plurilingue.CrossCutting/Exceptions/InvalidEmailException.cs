using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Infra.CrossCutting.Exceptions
{
    public class InvalidEmailException : PlurilingueException
    {
        public InvalidEmailException() : base("Invalid e-mail") { }
    }
}
