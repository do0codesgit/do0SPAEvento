using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace do0.Models
{
    public class do0Evento
    {
        [Display(Name = "ID")]
        public int do0EventoId { get; set; }
        [Display(Name = "STATUS DO CLIENTE")]
        public bool StatusDoEvento { get; set; }
        [Display(Name = "DATA DO CADASTRO")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataCadastro { get; set; }
        [Display(Name = "NOME DO AVATAR")]
        public string do0Avatar { get; set; }
        [Display(Name = "NOME DO USUÁRIO")]
        public string UserName { get; set; }
        [Display(Name = "DATA DO EVENTO")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "NOME COMPLETO")]
        public string NomeCompleto { get; set; }
        [Display(Name = "RESPONSÁVEL PELO EVENTO")]
        public string ResponsavelEvento { get; set; }
        [Display(Name = "NOME DO HOMENAGEADO")]
        public string NomeHomenageado { get; set; }
        [Display(Name = "TIPO DE HOMENAGEM")]
        public string TipoHomenagem { get; set; }

        [Display(Name = "CPF")]
        public string CPF { get; set; }
        [Display(Name = "IDENTIDADE")]
        [StringLength(15, ErrorMessage = "Confira os dados..")]
        public string Identidade { get; set; }
        [Display(Name = "ENDEREÇO COMPLETO")]
        [StringLength(200, ErrorMessage = "Confira os dados..")]
        public string Endereco { get; set; }
        [Display(Name = "E-MAIL")]
        [Required(ErrorMessage = "informe o seu email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }
        [StringLength(15, ErrorMessage = "Confira os dados..")]
        [Display(Name = "TELEFONE WHATSAPP")]
        public string Telefone1 { get; set; }
        [StringLength(15, ErrorMessage = "Confira os dados..")]
        [Display(Name = "TELEFONE ALTERNATIVO")]
        public string Telefone2 { get; set; }
        [StringLength(15, ErrorMessage = "Confira os dados..")]
        [Display(Name = "TELEFONE ADICIONAL")]
        public string Telefone3 { get; set; }
        [Display(Name = "OBSERVAÇÕES")]
        public string Observacoes { get; set; }


    }
}