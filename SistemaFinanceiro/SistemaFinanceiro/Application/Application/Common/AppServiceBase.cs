using Application.Interface.Common;
using Domain.Interface.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Application.Common
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }
    }
}
