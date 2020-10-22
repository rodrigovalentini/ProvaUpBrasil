using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Prova.WebUI.ViewModels
{
    public class BairroViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome do bairro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nom_bairro { get; set; }

        [HiddenInput]
        public bool Fl_ativo { get; set; }

        [HiddenInput]
        public Guid Cod_cidade { get; set; }
        public virtual CidadeViewModel Cidade { get; set; }
        public virtual IEnumerable<EnderecoClienteViewModel> EnderecoClientes { get; set; }
    }
}
