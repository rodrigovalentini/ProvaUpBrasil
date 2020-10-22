﻿using Prova.Business.Interfaces;
using Prova.Business.Models;
using Prova.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Data.Repository
{
    public class VendaItemRepository : Repository<VendaItem>, IVendaItemRepository
    {
        public VendaItemRepository(ProvaDbContext context) : base(context) { }
    }
}
