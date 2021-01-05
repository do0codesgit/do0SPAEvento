using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace do0.Models
{
    public class do0TipoEvento
    {
        [Display(Name = "ID")]
        public int do0TipoEventoId { get; set; }
        [Display(Name = "TIPO DE HOMENAGEM")]
        public string NomeEvento { get; set; }
        [Display(Name = "OBSERVAÇÕES")]
        public string Observacoes { get; set; }

        public virtual List<do0Evento> do0Eventos { get; set; }
    }
}