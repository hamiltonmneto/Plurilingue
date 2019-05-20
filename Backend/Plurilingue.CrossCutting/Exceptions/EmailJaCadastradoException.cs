using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Infra.CrossCutting.Exceptions
{
    public class EmailJaCadastradoException : PlurilingueException
    {
        public EmailJaCadastradoException() : base("E-mail already in use") { }
    }
}
