using System;
using System.Collections.Generic;

namespace Prova.Business.Models
{
    public class Bairro : Entity
    {
        public string Nom_bairro { get; set; }
        public bool Fl_ativo { get; set; }

        public Guid Cod_cidade { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual IEnumerable<EnderecoCliente> EnderecoClientes { get; set; }

    }
}
