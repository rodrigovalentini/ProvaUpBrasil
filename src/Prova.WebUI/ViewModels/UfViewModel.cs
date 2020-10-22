using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class UfViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome do estado")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nom_uf { get; set; }

        [DisplayName("Sigla")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Sgl_uf { get; set; }

        [HiddenInput]
        public bool Fl_ativo { get; set; }
    }
}
