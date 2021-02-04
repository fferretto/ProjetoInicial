using Domain.Entities;
using Domain.Interface.Repository;
using Domain.Interface.Services;
using Domain.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Services
{
    public class UsuarioService : ServiceBase<TBUsuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _rep;
        public UsuarioService(IUsuarioRepository rep)
            :base(rep)
        {
            _rep = rep;
        }

        public void AlteraUsuario(TBUsuario usu)
        {
            _rep.Update(usu);
        }

        public List<TBUsuario> BuscaTodosUsuariosAtivos()
        {
            var dados = _rep.Get(x => x.ATIVO).ToList();

            return dados;
        }

        public TBUsuario BuscaUsuarioByID(int codigoUsuario)
        {
            var dados = _rep.Get(x => x.CODUSUARIO == codigoUsuario).FirstOrDefault();

            return dados;
        }

        public void DesativaUsuario(int codigoUsuario)
        {
            var usuario = BuscaUsuarioByID(codigoUsuario);
            usuario.ATIVO = false;

            _rep.Update(usuario);
        }

        public void IncluiUsuario(TBUsuario usu)
        {
            _rep.Add(usu);
        }
    }
}
