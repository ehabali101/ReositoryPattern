using ReositoryPattern.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReositoryPattern.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolContext _context;
        public ITenantRepository TenantRepository { get; private set;}


        public UnitOfWork(SchoolContext context)
        {
            _context = context;
            TenantRepository = new TenantRepository(_context);
        }
  
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
