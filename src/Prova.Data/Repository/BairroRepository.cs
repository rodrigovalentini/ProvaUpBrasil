using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.Data.Context;

namespace Prova.Data.Repository
{
    public class BairroRepository : Repository<Bairro>, IBairroRepository
    {
        public BairroRepository(ProvaDbContext context) : base(context) { }
      
    }
}
