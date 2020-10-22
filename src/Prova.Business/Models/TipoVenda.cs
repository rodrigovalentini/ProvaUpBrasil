using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class TipoVenda : Entity
    {
        public string Nom_tipo_venda { get; set; }
        public string Des_tipo_venda { get; set; }
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<Venda> Vendas { get; set; }
    }
}
