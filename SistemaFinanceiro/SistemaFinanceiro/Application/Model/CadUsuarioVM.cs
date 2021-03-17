using Application.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Application.Model
{
    public class DadosUsuarioVM
    {
        private const string userIcon = "<i class='fa fa-user'></i>";
        private const string emailIcon = "<i class='fa fa-envelope'></i>";
        private const string foneIcon = "<i class='fa fa-phone'></i>";

        [Ajuda("è o código do Usuario")]
        [Display(Name = "Código")]
        public int codigoUsuario { get; set; }
        [Display(Name = "Nome")]
        [Ajuda("ajuda 2")]
        [InputAttrAux(Final = userIcon, Type = "search")]
        [StringLength(60)]
        [Required(ErrorMessage = "Obrigatorio informar o nome do usuário")]

        public string nomeUsuario { get; set; }

        [Display(Name = "E-mail")]
        [Ajuda("Campo que vai o email do usuario")]
        [InputAttrAux(Final = emailIcon, Type = "search")]
        [StringLength(60)]
        [Required(ErrorMessage = "Obrigatorio informar o E-mail")]

        public string Email { get; set; }

        [Display(Name = "Telefone")]
        [InputAttrAux(Final = foneIcon, Type = "search")]
        public string Fone { get; set; }

        [Display(Name = "Dt. de Nascimento")]
        [InputMask("99/99/9999", IsReverso = true)]
        [InputAttrAux(Final = "<i class='fa fa-calendar'></i>", Type = "search")]
        public string dataNascimento { get; set; }

        [InputAttrAux(Type = "search")]
        [Ajuda("Clica em CPF se deseja informar seu cpf<br/>Clica em CNPJ se deseja informar seu CNPJ")]
        [Required(ErrorMessage = "Informar CPF ou CNPJ")]
        public string Cpf { get; set; }

        [Display(Name = "Valor")]
        [InputAttrAux(Final = "R$")]
        [InputMask("#.##0,00", IsReverso = true)]
        [StringLength(10)]
        public string ValorTeste { get; set; }
    }
}
