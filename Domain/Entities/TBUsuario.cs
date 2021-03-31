using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TBUsuario
    {
        public int CODUSUARIO { get; set; }
        public string NMUSUARIO { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }
        public DateTime dtNascimento { get; set; }
        public DateTime dtCadastro { get; set; }
        public string CPF { get; set; }
        public string EMAIL { get; set; }
        public bool ATIVO { get; set; }
    }
}
