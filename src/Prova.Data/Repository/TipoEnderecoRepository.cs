using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.Data.Context;

namespace Prova.Data.Repository
{
    public class TipoEnderecoRepository : Repository<TipoEndereco>, ITipoEnderecoRepository
    {
        public TipoEnderecoRepository(ProvaDbContext context) : base(context) { }
    }
}
