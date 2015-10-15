using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBox.Domain.Clients.TransacaoFinanceiras
{
    public class TransacaoFinanceiraDTO
    {
        public string Credito { get; internal set; }
        public string DataReferencia { get; internal set; }
        public string Debito { get; internal set; }
        public string Descricao { get; internal set; }
        public string Saldo { get; internal set; }
        public decimal Valor { get; internal set; }
    }
}
