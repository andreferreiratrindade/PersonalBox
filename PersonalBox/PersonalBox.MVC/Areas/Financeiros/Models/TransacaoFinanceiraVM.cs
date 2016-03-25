using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalBox.MVC.Areas.Financeiros.Models
{
    public class TransacaoFinanceiraVM
    {
        [Required]
        public int TransacaoFinanceiraId { get; set; }
        [Required]
        public decimal Valor { get; set; }
        public string  Descricao { get; set; }
        [Required]
        public DateTime DataReferencia { get; set; }
    }
}
