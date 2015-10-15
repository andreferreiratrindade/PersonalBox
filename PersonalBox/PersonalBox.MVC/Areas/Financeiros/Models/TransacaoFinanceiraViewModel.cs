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
        public IEnumerable<TransacaoFinanceiraDTO> TransacoesFinanceiras { get; internal set; }
    }
}
