
using ReositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReositoryPattern.Repositories
{
    internal interface ITenantRepository: IRepository<Tenant>
    {
        IEnumerable<Tenant> GetTopTenants(int count);
        IEnumerable<Tenant> GetTenantsByStatus(string status);
    }
}
