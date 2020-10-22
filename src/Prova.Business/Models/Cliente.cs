using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class Cliente : Entity
    {
        public string Nom_cliente { get; set; }
        public DateTime Dt_cadastramento { get; set; }
        public string Des_observacao { get; set; }
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<EnderecoCliente> EnderecoClientes { get; set; }
        public virtual IEnumerable<Venda> Vendas { get; set; }
    }
}
