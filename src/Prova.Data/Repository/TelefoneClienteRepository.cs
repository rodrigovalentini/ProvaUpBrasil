using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.Data.Context;

namespace Prova.Data.Repository
{
    public class TelefoneClienteRepository : Repository<TelefoneCliente>, ITelefoneClienteRepository
    {
        public TelefoneClienteRepository(ProvaDbContext context) : base(context) { }
    }
}
