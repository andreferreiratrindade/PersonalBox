using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBox.Domain.Clients.TransacaoFinanceiras;

namespace PersonalBox.MVC.Areas.Financeiros.Models
{
    public class TransacaoFinanceiraViewModel
    {
        public TransacaoFinanceiraVM TransacaoFinanceiraVM { get; set; }
        public IEnumerable<TransacaoFinanceiraDTO> TransacoesFinanceiras { get; internal set; }
        public string SaldoAtualStr { get; set; }

        public TransacaoFinanceiraViewModel()
        {
            TransacaoFinanceiraVM = new TransacaoFinanceiraVM();
        }
    }
}
