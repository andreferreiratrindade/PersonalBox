using PersonalBox.Domain.Entities.Constants;
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
        public DateTime DataReferencia { get; internal set; }
        public TipoTransacaoFinanceira Tipo { get; set; }
        public string Descricao { get; internal set; }
        public string Saldo { get; internal set; }
        public decimal Valor { get; internal set; }
        public string ValorStr { get; set; }
        public string DataReferenciaStr { get; internal set; }
        public int TransacaoFinanceiroId { get; internal set; }
    }
}
