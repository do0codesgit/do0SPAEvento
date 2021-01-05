using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace do0.Models
{
    public class do0EventoPagamento
    {
        [Display(Name = "ID")]
        public int do0EventoPagamentoId { get; set; }
        [Display(Name = "TIPO DE PAGAMENTO")]
        public string NomePagamento { get; set; }
        [Display(Name = "OBSERVAÇÕES")]
        public string Observacoes { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string EmailSandbox { get; set; }
        public string SenhaSandbox { get; set; }

        public virtual List<do0Evento> do0Eventos { get; set; }
    }
}