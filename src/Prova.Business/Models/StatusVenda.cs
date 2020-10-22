using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class StatusVenda : Entity
    {
        public string Nom_status_venda { get; set; }
        public string Des_status_venda { get; set; }
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<Venda> Vendas { get; set; }
    }
}
