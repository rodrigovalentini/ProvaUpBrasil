using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class GrupoItem : Entity
    {
        public string Nom_grupo_item { get; set; }
        public string Des_grupo_item { get; set; }
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<Item> Items { get; set; }
    }
}
