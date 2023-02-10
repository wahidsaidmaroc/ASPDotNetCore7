using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SeedWorks
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangeAsync();
    }
}
