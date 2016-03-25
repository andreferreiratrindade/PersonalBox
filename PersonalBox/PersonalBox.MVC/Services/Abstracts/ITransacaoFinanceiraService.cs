using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBox.MVC.Areas.Financeiros.Models;

namespace PersonalBox.MVC.Services.Abstracts
{
    public interface ITransacaoFinanceiraService
    {
        TransacaoFinanceiraViewModel GetIndex(string userId, int mes, int ano);
    }
}
