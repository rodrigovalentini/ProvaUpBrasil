using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class TipoEndereco : Entity
    {
        public string nom_tipo_endereco { get; set; }
        public string Des_tipo_endereco { get; set; }
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<EnderecoCliente> EnderecoClientes { get; set; }
    }
}
