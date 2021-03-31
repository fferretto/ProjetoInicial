using Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interface
{
    public interface IUsarioApp
    {
        DadosUsuarioVM BuscaUsuarioByID(int codigoUsuario);
        List<DadosUsuarioVM> BuscaTodosUsuarios();
        IDictionary<bool, string> SalvarUsuario(DadosUsuarioVM dadosUsu);
        IDictionary<bool, string> DesativaUsuario(int codigoUsuario);
    }
}
