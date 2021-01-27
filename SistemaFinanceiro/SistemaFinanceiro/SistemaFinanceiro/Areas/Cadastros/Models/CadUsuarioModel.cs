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
        [Ajuda("è o código do Usuario")]
        [Display(Name = "Código")]
        public int codigoUsuario { get; set; }

        [Display(Name = "Nome do Usuário")]
        [Ajuda("ajuda 2")]
        [StringLength(60)]
        [Required(ErrorMessage = "Obrigatorio informar o nome do usuário")]
        public string nomeUsuario { get; set; }


        [Display(Name = "Valor")]
        [InputAttributeAux(Inicio = "R$")]
        [InputMask("#.##0,00", IsReverso = true)]
        [StringLength(10)]
        public string ValorTeste { get; set; }


        [Display(Name = "Data de Nascimento")]
        [InputMask("99/99/9999", IsReverso = true)]
        [InputAttributeAux(Final = "<i class='fa fa-calendar'></i>")]
        public string dataNascimento { get; set; }
    }
}
