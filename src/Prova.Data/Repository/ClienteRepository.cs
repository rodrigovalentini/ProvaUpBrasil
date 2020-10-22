using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ProvaDbContext context) : base(context) { }
    }
}
