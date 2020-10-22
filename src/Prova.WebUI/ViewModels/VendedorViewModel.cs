using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class VendedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome do vendedor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nom_vendedor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Dt_cadastramento { get; set; }

        [HiddenInput]
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<VendaViewModel> Vendas { get; set; }
    }
}
