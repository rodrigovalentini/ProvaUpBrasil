using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class EnderecoClienteViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Logradouro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Des_endereco { get; set; }

        [DisplayName("Complemento")]
        [StringLength(255)]
        public string Des_complemento { get; set; }

        [DisplayName("Caixa Posta")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(18, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Idt_caixa_postal { get; set; }

        [DisplayName("CEP")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(18, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Idt_cep { get; set; }

        [DisplayName("Observação")]
        [StringLength(255)]
        public string Des_observacao { get; set; }

        [HiddenInput]
        public bool Fl_ativo { get; set; }
        [HiddenInput]
        public Guid Cod_cliente { get; set; }
        [HiddenInput]
        public Guid Cod_tipo_endereco { get; set; }
        [HiddenInput]
        public Guid Cod_bairro { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
        public virtual TipoEnderecoViewModel TipoEndereco { get; set; }
        public virtual BairroViewModel Bairro { get; set; }
    }
}
