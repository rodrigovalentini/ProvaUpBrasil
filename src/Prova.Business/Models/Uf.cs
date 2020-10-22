using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class Uf: Entity
    {
        public string Nom_uf { get; set; }
        public string Sgl_uf { get; set; }
        public bool Fl_ativo { get; set; }
        public virtual IEnumerable<Cidade> Cidades { get; set; }
    }
}
