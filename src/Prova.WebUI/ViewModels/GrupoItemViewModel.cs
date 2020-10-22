using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class GrupoItemViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome do grupo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nom_grupo_item { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Des_grupo_item { get; set; }

        [HiddenInput]
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<ItemViewModel> Items { get; set; }
    }
}
