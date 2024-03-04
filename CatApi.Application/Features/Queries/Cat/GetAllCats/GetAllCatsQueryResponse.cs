using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Application.Features.Queries.Cat.GetAllCats
{
    public class GetAllCatsQueryResponse
    {
        public int TotalCatCount { get; set; }
        public object Cats { get; set; }
    }
}
