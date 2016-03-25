using PersonalBox.Domain.Interfaces.Clients;
using PersonalBox.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBox.Domain.Entities;
using PersonalBox.Domain.Utils;
using PersonalBox.Domain.Entities.Constants;

namespace PersonalBox.Domain.Clients.TransacaoFinanceiras
{
    public class TransacaoFinanceiraClient : ITransacaoFinanceiraClient
    {
        private readonly ITransacaoFinanceiraRepository _transacaoFinanceiraRepository;
        private readonly IUsuarioClient _usuarioClient;
        public TransacaoFinanceiraClient(ITransacaoFinanceiraRepository transacaoFinanceiraRepository, IUsuarioClient usuarioClient)
        {
            _transacaoFinanceiraRepository = transacaoFinanceiraRepository;
            _usuarioClient = usuarioClient;
        }

        public IEnumerable<TransacaoFinanceiraDTO> GetTransacoesFinanceirasByDataReferencia(string UsuarioId, int mes, int ano)
        {
            var list = _transacaoFinanceiraRepository.All().Where(x => x.UsuarioId == UsuarioId
            && x.DataReferencia.Month == mes && x.DataReferencia.Year == ano)
                  .Select(x => new TransacaoFinanceiraDTO
                  {
                      TransacaoFinanceiroId = x.TransacaoFincanceiraId,
                      Tipo = x.TipoTransacaoFinanceira,
                      Descricao = x.Descricao,
                      Valor = x.Valor,
                      DataReferencia = x.DataReferencia
                  }).ToList();
            list.ForEach(x =>
            {
                x.DataReferenciaStr = x.DataReferencia.ToString("dd/MM/yyyy");
                x.ValorStr = x.Valor.ToString("N");
            });

            return list.OrderBy(x => x.DataReferencia).ThenBy(x => x.TransacaoFinanceiroId);
        }

        public ReturnOperation SetCreate(TransacaoFinanceira transacao)
        {
            var returnOperation = new ReturnOperation();

            _transacaoFinanceiraRepository.Add(transacao);
            _usuarioClient.AtualizaSaldo(transacao.Valor, transacao.TipoTransacaoFinanceira, transacao.UsuarioId);

            return returnOperation;
        }

        public ReturnOperation SetDelete(int transferenciaId)
        {
            var returnOperation = new ReturnOperation();
            var transacao = _transacaoFinanceiraRepository.GetById(transferenciaId);

            _usuarioClient.AtualizaSaldo(-transacao.Valor, transacao.TipoTransacaoFinanceira, transacao.UsuarioId);

            _transacaoFinanceiraRepository.Remove(transacao);
            return returnOperation;
        }
    }
}
