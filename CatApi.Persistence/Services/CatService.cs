using CatApi.Application.Repositories;
using CatApi.Application.Services;
using CatApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Persistence.Services
{
    public class CatService : ICatService
    {
        private readonly ICatReadRepository _readRepository;

        public CatService(ICatReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public IQueryable<Cat> GetCats()
        {
            var query = _readRepository.GetAll();
            return query;
        }
    }
}
