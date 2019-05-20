using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Infra.CrossCutting.Exceptions
{
    public class EmailNaoCadastradoException : PlurilingueException
    {
        public EmailNaoCadastradoException() : base("Email not registered") { }
    }
}
