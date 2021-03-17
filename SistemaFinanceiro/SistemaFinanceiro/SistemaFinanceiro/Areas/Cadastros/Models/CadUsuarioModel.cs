using SistemaFinanceiro.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Areas.Cadastros.Models
{
    public class FiltroCadUsuarioModel
    {
        private const string userIcon = "<i class='fa fa-user'></i>";
        private const string emailIcon = "<i class='fa fa-envelope'></i>";
        private const string foneIcon = "<i class='fa fa-phone'></i>";

        [Ajuda("è o código do Usuario")]
        [Display(Name = "Código")]
        public int codigoUsuario { get; set; }
        [Display(Name = "Nome")]
        [Ajuda("ajuda 2")]
        [InputAttributeAux(Final = userIcon, Type = "search")]
        [StringLength(60)]
        [Required(ErrorMessage = "Obrigatorio informar o nome do usuário")]
        
        public string nomeUsuario { get; set; }

        [Display(Name = "E-mail")]
        [Ajuda("Campo que vai o email do usuario")]
        [InputAttributeAux(Final = emailIcon, Type = "search")]
        [StringLength(60)]
        [Required(ErrorMessage = "Obrigatorio informar o E-mail")]

        public string Email { get; set; }

        [Display(Name = "Telefone")]
        [InputAttributeAux(Final = foneIcon, Type = "search")]
        public string Fone { get; set; }

        [Display(Name = "Dt. de Nascimento")]
        [InputMask("99/99/9999", IsReverso = true)]
        [InputAttributeAux(Final = "<i class='fa fa-calendar'></i>", Type = "search")]
        public string dataNascimento { get; set; }

        [InputAttributeAux(Type = "search")]
        [Ajuda("Clica em CPF se deseja informar seu cpf<br/>Clica em CNPJ se deseja informar seu CNPJ")]
        [Required(ErrorMessage = "Informar CPF ou CNPJ")]
        public string Cpf { get; set; }

        [Display(Name = "Valor")]
        [InputAttributeAux(Final = "R$")]
        [InputMask("#.##0,00", IsReverso = true)]
        [StringLength(10)]
        public string ValorTeste { get; set; }
    }
}
