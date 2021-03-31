using Application.Helpers;
using Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Application.Model
{
    public class DadosUsuarioVM
    {
        private const string userIcon = "<i class='fa fa-user'></i>";
        private const string emailIcon = "<i class='fa fa-envelope'></i>";
        private const string foneIcon = "<i class='fa fa-phone'></i>";

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

        [Display(Name = "Dt. de Cadastro")]
        [InputMask("99/99/9999", IsReverso = true)]
        [InputAttrAux(Final = "<i class='fa fa-calendar'></i>", Type = "search")]
        public string dataCadastro { get; set; }

        [InputAttrAux(Type = "search")]
        [Ajuda("Clica em CPF se deseja informar seu cpf<br/>Clica em CNPJ se deseja informar seu CNPJ")]
        [Required(ErrorMessage = "Informar CPF ou CNPJ")]
        public string Cpf { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Obrigatório informar o Login")]
        [StringLength(60)]
        public string Login { get; set; }


        [StringLength(16, ErrorMessage = "A senha deverá conter entre 6 a 16 caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha *")]
        //[Required(ErrorMessage = "Obrigatório informar a senha")]
        [Ajuda("A senha deverá conter entre 6 a 16 caracteres. Este campo é obrigatório apenas para novos cadastros")]
        public string Password { get; set; }

        [Display(Name = "Confirmar Senha *")]
        [Ajuda("A senha deverá conter entre 6 a 16 caracteres. Este campo é obrigatório apenas para novos cadastros")]
        [Compare("Password", ErrorMessage = "Senhas não conferem.")]
        //[Required(ErrorMessage = "Obrigatório confirmar a senha")]
        [DataType(DataType.Password)]
        [StringLength(16)]
        public string ConfirmPassword { get; set; }

        public static DadosUsuarioVM ToView(TBUsuario usu)
        {
            return new DadosUsuarioVM()
            {
                codigoUsuario = usu.CODUSUARIO,
                nomeUsuario = usu.NMUSUARIO,
                Email = usu.EMAIL,
                dataNascimento = usu.dtNascimento.ToShortDateString(),
                Cpf = Geral.FormataCPFCnPj(usu.CPF),
                dataCadastro = usu.dtNascimento.ToShortDateString(),
                Login = usu.LOGIN

            };
        }

        internal static IList<DadosUsuarioVM> ToListView<T>(ICollection<T> collection) where T : TBUsuario
        {
            return collection.Select(x => ToListView(x)).ToList();
        }

        internal static DadosUsuarioVM ToListView(TBUsuario usu)
        {
            return new DadosUsuarioVM
            {
                codigoUsuario = usu.CODUSUARIO,
                nomeUsuario = usu.NMUSUARIO,
                Email = usu.EMAIL,
                dataNascimento = usu.dtNascimento.ToShortDateString(),
                Cpf = Geral.FormataCPFCnPj(usu.CPF),
                dataCadastro = usu.dtNascimento.ToShortDateString(),
                Login = usu.LOGIN

            };
        }

    }
}
