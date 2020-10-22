using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class VendaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Dt_cadastramento { get; set; }

        [DisplayName("Data da venda")]
        public DateTime Dt_venda { get; set; }

        [DisplayName("Valor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public decimal Vlr_total_item { get; set; }

        [DisplayName("Valor total com desconto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public decimal Vlr_total_desconto { get; set; }

        [DisplayName("Valor Total")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public decimal Vlr_total_venda { get; set; }

        [DisplayName("Observação")]
        [StringLength(255)]
        public string Des_observacao { get; set; }

        [HiddenInput]
        public Guid Cod_tipo_venda { get; set; }

        [HiddenInput]
        public Guid Cod_status_venda { get; set; }

        [HiddenInput]
        public Guid Cod_vendedor { get; set; }

        [DisplayName("Cliente")]
        public Guid Cod_cliente { get; set; }
        public virtual StatusVendaViewModel StatusVenda { get; set; }
        public virtual TipoVendaViewModel TipoVenda { get; set; }
        public virtual VendedorViewModel Vendedor { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
        public virtual IEnumerable<VendaItemViewModel> VendaItens { get; set; }
    }
}
