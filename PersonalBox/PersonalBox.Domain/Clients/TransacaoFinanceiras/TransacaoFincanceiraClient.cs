using PersonalBox.Domain.Interfaces.Clients;
using PersonalBox.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBox.Domain.Clients.TransacaoFinanceiras
{
    public class TransacaoFinanceiraClient : ITransacaoFinanceiraClient
    {
        private readonly ITransacaoFinanceiraRepository _transacaoFinanceiraRepository;

        public TransacaoFinanceiraClient(ITransacaoFinanceiraRepository transacaoFinanceiraRepository)
        {
            _transacaoFinanceiraRepository = transacaoFinanceiraRepository;
        }

        public IEnumerable<TransacaoFinanceiraDTO> GetTransacoesFinanceirasByDataReferencia(string userId, DateTime now)
        {
            return _transacaoFinanceiraRepository.All().Where(x => x.User.UserIdentityId == userId )
           // && x.DataReferencia.Date == now.Date)
                  .Select(x => new TransacaoFinanceiraDTO
                  {
                      Descricao = x.Descricao,
                      Valor = x.Valor,  
                  //    DataReferencia = x.DataReferencia.ToString("dd/MM/yyyy")
                  }).ToList();
        }
    }
}
