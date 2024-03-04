using CatApi.Application.Repositories;
using CatApi.Domain.Entities;
using CatApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Persistence.Repositories
{
    public class CatReadRepository : ReadRepository<Cat>, ICatReadRepository
    {
        public CatReadRepository(CatApiDbContext context) : base(context)
        {
        }
    }
}
