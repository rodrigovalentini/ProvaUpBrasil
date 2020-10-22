using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class TipoEnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Tipo de endereço")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string nom_tipo_endereco { get; set; }

        [DisplayName("Observação")]
        [StringLength(255)]
        public string Des_tipo_endereco { get; set; }

        [HiddenInput]
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<EnderecoClienteViewModel> EnderecoClientes { get; set; }
    }
}
