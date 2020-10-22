using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.Data.Context;

namespace Prova.Data.Repository
{
    public class EnderecoClienteRepository : Repository<EnderecoCliente>, IEnderecoClienteRepository
    {
        public EnderecoClienteRepository(ProvaDbContext context) : base(context) { }
    }
}
