using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class Vendedor: Entity
    {
        public string Nom_vendedor { get; set; }
        public DateTime Dt_cadastramento { get; set; }
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<Venda> Vendas { get; set; }
    }
}
