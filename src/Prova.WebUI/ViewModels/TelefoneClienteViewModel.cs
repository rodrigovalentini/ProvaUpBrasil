using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class TelefoneClienteViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Código de área")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Idt_codigo_area { get; set; }

        [DisplayName("Número")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(18, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Idt_num_telefone { get; set; }

        [DisplayName("Observação")]
        [StringLength(255)]
        public string Des_observacao { get; set; }

        [DisplayName("Ativo")]
        public bool Fl_ativo { get; set; }

        [HiddenInput]
        public Guid Cod_cliente { get; set; }

        [HiddenInput]
        public Guid Cod_tipo_telefone { get; set; }
        public virtual TipoTelefoneViewModel TipoTelefone { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}
