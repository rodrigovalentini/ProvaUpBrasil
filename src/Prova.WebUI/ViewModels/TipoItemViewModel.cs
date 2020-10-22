using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class TipoItemViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Tipo de item")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nom_tipo_item { get; set; }

        [DisplayName("Observação")]
        [StringLength(255)]
        public string Des_tipo_item { get; set; }
        public bool Fl_ativo { get; set; }

        public virtual ItemViewModel Item { get; set; }

        [HiddenInput]
        public Guid Cod_item { get; set; }
        public virtual IEnumerable<ItemViewModel> Items { get; set; }
    }
}
