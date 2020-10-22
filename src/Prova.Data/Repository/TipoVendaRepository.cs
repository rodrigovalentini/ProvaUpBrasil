using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Data.Repository
{
    public class TipoVendaRepository : Repository<TipoVenda>, ITipoVendaRepository
    {
        public TipoVendaRepository(ProvaDbContext context) : base(context) { }
    }
}
