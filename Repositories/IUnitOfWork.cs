using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReositoryPattern.Repositories
{
    internal interface IUnitOfWork : IDisposable
    {
        ITenantRepository TenantRepository { get; }






        int Complete();
    }
}
