using Domain.Entities;
using Domain.Interface.Repository;
using Infra.Data.Context;
using Infra.Data.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<TBUsuario>, IUsuarioRepository
    {
        public UsuarioRepository(ContextDB context)
            : base(context)
        { }
    }
}

