using CatApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Application.Repositories
{
    public interface ICatReadRepository : IReadRepository<Cat>
    {
    }
}
