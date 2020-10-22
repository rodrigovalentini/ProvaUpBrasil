using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class Cidade : Entity
    {
        public string Nom_cidade { get; set; }
        public bool Fl_ativo { get; set; }

        public Guid Cod_uf { get; set; }
        public virtual Uf Uf { get; set; }
        public virtual IEnumerable<Bairro> Bairros { get; set; }
    }
}
