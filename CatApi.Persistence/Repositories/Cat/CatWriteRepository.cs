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
    public class CatWriteRepository : WriteRepository<Cat>, ICatWriteRepository
    {
        public CatWriteRepository(CatApiDbContext context) : base(context)
        {
        }
    }
}
