using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class TipoTelefone : Entity
    {
        public string Nom_tipo_telefone { get; set; }
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<TelefoneCliente> TelefoneClientes { get; set; }
    }
}
