using Application.Interface;
using Application.Model;
using Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Application
{
    public class UsarioApp : IUsarioApp
    {
        private readonly IUsuarioService _usuario;

        public UsarioApp(IUsuarioService usuario)
        {
            _usuario = usuario;
        }

        public List<DadosUsuarioVM> BuscaTodosUsuarios()
        {
            throw new NotImplementedException();
        }

        public DadosUsuarioVM BuscaUsuarioByID(int codigoUsuario)
        {
            throw new NotImplementedException();
        }

        public IDictionary<bool, string> DesativaUsuario(int codigoUsuario)
        {
            throw new NotImplementedException();
        }

        public IDictionary<bool, string> SalvarUsuario(DadosUsuarioVM dadosUsu)
        {
            throw new NotImplementedException();
        }
    }
}
