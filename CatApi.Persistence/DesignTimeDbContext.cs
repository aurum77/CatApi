using CatApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CatApiDbContext>
    {
        public CatApiDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CatApiDbContext> builder = new();

            builder.UseNpgsql<CatApiDbContext>(Configuration.PostgreSQLConnectionString);

            return new(builder.Options);
        }
    }
}
