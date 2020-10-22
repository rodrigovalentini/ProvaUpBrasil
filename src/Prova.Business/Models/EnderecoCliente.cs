using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Business.Models
{
    public class EnderecoCliente : Entity
    {
        public string Des_endereco { get; set; }
        public string Des_complemento { get; set; }
        public string Idt_caixa_postal { get; set; }
        public string Idt_cep { get; set; }
        public string Des_observacao { get; set; }
        public bool Fl_ativo { get; set; }

        public Guid Cod_cliente { get; set; }
        public Guid Cod_tipo_endereco { get; set; }
        public Guid Cod_bairro { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual TipoEndereco TipoEndereco { get; set; }
        public virtual Bairro Bairro { get; set; }
    }
}
