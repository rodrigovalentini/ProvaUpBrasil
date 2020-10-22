using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Prova.WebUI.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome do cliente")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nom_cliente { get; set; }

        [DisplayName("Data do cadastro")]
        public DateTime Dt_cadastramento { get; set; }

        [DisplayName("Observação")]
        [StringLength(255)]
        public string Des_observacao { get; set; }

        [DisplayName("Ativo")]
        public bool Fl_ativo { get; set; }

        public virtual IEnumerable<EnderecoClienteViewModel> EnderecoClientes { get; set; }
        public virtual IEnumerable<VendaViewModel> Vendas { get; set; }
    }
}
