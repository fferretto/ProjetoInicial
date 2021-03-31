using Domain.Entities;
using Domain.Interface.Services.Common;
using System.Collections.Generic;

namespace Domain.Interface.Services
{
    public interface IUsuarioService : IServiceBase<TBUsuario>
    {
        TBUsuario BuscaUsuarioByID(int codigoUsuario);
        List<TBUsuario> BuscaTodosUsuariosAtivos();
        void IncluiUsuario(TBUsuario usu);
        void AlteraUsuario(TBUsuario usu);
        void DesativaUsuario(int codigoUsuario);
    }
}
