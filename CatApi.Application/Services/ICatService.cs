using CatApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Application.Services
{
    public interface ICatService
    {
        public IQueryable<Cat> GetCats();
    }
}
