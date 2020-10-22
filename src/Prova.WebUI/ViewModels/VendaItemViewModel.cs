using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class VendaItemViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Quantidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(18, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public decimal Qtd_item { get; set; }

        [DisplayName("Valor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(18, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public decimal Vlr_item { get; set; }

        [DisplayName("Desconto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(18, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public decimal Vlr_desconto { get; set; }

        [DisplayName("Total")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(18, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public decimal Vlr_total_item { get; set; }

        [HiddenInput]
        public Guid Cod_item { get; set; }

        [HiddenInput]
        public Guid Cod_venda { get; set; }
        public virtual ItemViewModel Item { get; set; }
        public virtual VendaViewModel Venda { get; set; }
    }
}
