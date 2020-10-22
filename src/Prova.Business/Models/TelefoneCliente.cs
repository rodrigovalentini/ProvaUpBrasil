using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class TelefoneCliente : Entity
    {
        public string Idt_num_telefone { get; set; }
        public string Idt_codigo_area { get; set; }
        public string Des_observacao { get; set; }
        public bool Fl_ativo { get; set; }
        public Guid Cod_cliente { get; set; }
        public Guid Cod_tipo_telefone { get; set; }
        public virtual TipoTelefone TipoTelefone { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
