using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class ItemViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome do item")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nom_item { get; set; }

        [DisplayName("Quantidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public decimal Qtd_Item { get; set; }

        [DisplayName("Quantidade mínima")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public decimal Qtd_minima_item { get; set; }

        [DisplayName("Valor do item")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public decimal Vlr_item { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Dt_cadastramento { get; set; }

        [DisplayName("Ativo")]
        public bool Fl_ativo { get; set; }

        [HiddenInput]
        public Guid Cod_grupo_item { get; set; }

        [HiddenInput]
        public Guid Cod_tipo_item { get; set; }

        public virtual GrupoItemViewModel GrupoItem { get; set; }
        public virtual TipoItemViewModel TipoItem { get; set; }

        public virtual IEnumerable<VendaItemViewModel> VendaItens { get; set; }
    }
}
