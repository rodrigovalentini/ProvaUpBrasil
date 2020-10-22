using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class VendaItem : Entity
    {
        public decimal Qtd_item { get; set; }
        public decimal Vlr_item { get; set; }
        public decimal Vlr_desconto { get; set; }
        public decimal Vlr_total_item { get; set; }

        public Guid Cod_item { get; set; }
        public Guid Cod_venda { get; set; }
        public virtual Item Item { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
