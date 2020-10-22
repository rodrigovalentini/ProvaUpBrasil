using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class TipoItem : Entity
    {
        public string Nom_tipo_item { get; set; }
        public string Des_tipo_item { get; set; }
        public bool Fl_ativo { get; set; }

        public virtual Item Item { get; set; }
        public Guid Cod_item { get; set; }
        public virtual IEnumerable<Item> Items { get; set; }
    }
}
