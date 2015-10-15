using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBox.MVC.Areas.Financeiros.Models
{
   public class TransacaoFinanceiraVM
    {
        public int TransacaoFinanceiraId { get; set; }
        public decimal Valor { get; set; }
        public string  Descricao { get; set; }
        public DateTime DataReferencia { get; set; }
    }
}
