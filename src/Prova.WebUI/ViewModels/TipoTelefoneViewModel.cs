using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class TipoTelefoneViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Tipo de telefone")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(18, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nom_tipo_telefone { get; set; }

        [HiddenInput]
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<TelefoneClienteViewModel> TelefoneClientes { get; set; }
    }
}
