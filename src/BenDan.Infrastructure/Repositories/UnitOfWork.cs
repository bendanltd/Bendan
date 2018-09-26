using BenDan.Core.Interfaces;
using BenDan.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BenDan.Infrastructure.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly BaseContext _baseContext;
        public UnitOfWork(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        public async Task<bool> SaveAsync()
        {
            return await _baseContext.SaveChangesAsync() > 0;
        }
    }
}
