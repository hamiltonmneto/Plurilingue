using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Infra.CrossCutting.Exceptions
{
    public class PlurilingueException : Exception
    {
        public PlurilingueException() { }
        public string Mensagem { get; private set; }
        public IDictionary<string, string> ChaveMensagem { get; private set; }
        public PlurilingueException(string mensagem) : this(mensagem, null) { }

        public PlurilingueException(string mensagem, Exception innerException)
        : base(mensagem, innerException)
        {
            Mensagem = mensagem;
            ChaveMensagem = new Dictionary<string, string>() { { "Erro", mensagem } };
        }

    }
}
