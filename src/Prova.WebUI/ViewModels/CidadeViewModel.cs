using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class CidadeViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome da cidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nom_cidade { get; set; }
        public bool Fl_ativo { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]

        [HiddenInput]
        public Guid Cod_uf { get; set; }
        public virtual UfViewModel Uf { get; set; }
        public virtual IEnumerable<BairroViewModel> Bairros { get; set; }
    }
}
