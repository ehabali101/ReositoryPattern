using Microsoft.EntityFrameworkCore;
using ReositoryPattern.Models;
using ReositoryPattern.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReositoryPattern.Repositories
{
    internal class TenantRepository : Repository<Tenant>, ITenantRepository
    {
        public TenantRepository(SchoolContext context) : base(context)
        {
            
        }

        public override IEnumerable<Tenant> GetAll()
        {
            return new List<Tenant>()
            {
                new Tenant() { Id = 1 },
                new Tenant() { Id = 2 },
                new Tenant() { Id = 3 },
                new Tenant() { Id = 4 },
                new Tenant() { Id = 5 }
            };
        }

        public IEnumerable<Tenant> GetTenantsByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tenant> GetTopTenants(int count)
        {
            throw new NotImplementedException();
        }

    }
}
