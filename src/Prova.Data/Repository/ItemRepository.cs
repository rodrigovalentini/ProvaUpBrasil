using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.Data.Context;

namespace Prova.Data.Repository
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(ProvaDbContext context) : base(context) { }
    }
}
