using DAL.Data;
using Infrastructure.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly FormationOumdinAcademyContext _db;
        private bool _disposed;

        public UnitOfWork(FormationOumdinAcademyContext db)
        {
            _db = db;
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _db.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Task<int> SaveChangeAsync()
        {
            return _db.SaveChangesAsync();
        }
    }
}
