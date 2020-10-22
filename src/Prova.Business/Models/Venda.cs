using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
   public class Venda: Entity
    {
        public DateTime Dt_cadastramento { get; set; }
        public DateTime Dt_venda { get; set; }
        public decimal Vlr_total_item { get; set; }
        public decimal Vlr_total_desconto { get; set; }
        public decimal Vlr_total_venda { get; set; }
        public string Des_observacao { get; set; }

        public Guid Cod_tipo_venda { get; set; }
        public Guid Cod_status_venda { get; set; }
        public Guid Cod_vendedor { get; set; }
        public Guid Cod_cliente { get; set; }
        public virtual StatusVenda StatusVenda { get; set; }
        public virtual TipoVenda TipoVenda { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual IEnumerable<VendaItem> VendaItens { get; set; }
    }
}
