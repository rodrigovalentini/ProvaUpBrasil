﻿using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Data.Repository
{
    public class StatusVendaRepository : Repository<StatusVenda>, IStatusVendaRepository
    {
        public StatusVendaRepository(ProvaDbContext context) : base(context) { }
    }
}
