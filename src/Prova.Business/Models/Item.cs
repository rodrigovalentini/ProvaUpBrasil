using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class Item : Entity
    {
        public string  Nom_item { get; set; }
        public decimal Qtd_Item { get; set; }
        public decimal Qtd_minima_item { get; set; }
        public decimal Vlr_item { get; set; }
        public DateTime Dt_cadastramento { get; set; }
        public bool Fl_ativo { get; set; }
        public Guid Cod_grupo_item { get; set; }
        public Guid Cod_tipo_item { get; set; }
        public virtual GrupoItem GrupoItem { get; set; }
        public virtual TipoItem TipoItem { get; set; }

        public virtual IEnumerable<VendaItem> VendaItens { get; set; }
    }
}
