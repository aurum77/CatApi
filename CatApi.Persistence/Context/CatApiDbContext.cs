using CatApi.Domain.Entities;
using CatApi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Persistence.Context
{
    public class CatApiDbContext : DbContext
    {
        public CatApiDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Cat> Cats { get; set; }

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entities = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in entities)
            {
                if (data.State == EntityState.Modified)
                {
                    data.Entity.UpdateDate = DateTime.UtcNow;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
