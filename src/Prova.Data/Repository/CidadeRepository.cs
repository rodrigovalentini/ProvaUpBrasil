using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Data.Repository
{
    public class CidadeRepository : Repository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(ProvaDbContext context) : base(context) { }
    }
}
