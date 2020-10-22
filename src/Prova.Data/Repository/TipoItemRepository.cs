using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.Data.Context;

namespace Prova.Data.Repository
{
    public class TipoItemRepository : Repository<TipoItem>, ITipoItemRepository
    {
        public TipoItemRepository(ProvaDbContext context) : base(context) { }
    }
}
