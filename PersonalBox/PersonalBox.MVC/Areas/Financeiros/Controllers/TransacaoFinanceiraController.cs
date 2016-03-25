using log4net;
using Microsoft.AspNet.Identity;
using PersonalBox.MVC.Areas.Financeiros.Models;
using PersonalBox.MVC.Services.Abstracts;
using System;
using System.Web.Mvc;

namespace PersonalBox.MVC.Areas.Financeiros.Controllers
{
    [Authorize]
    public class TransacaoFinanceiraController : Controller
    {
        private readonly ITransacaoFinanceiraService _transacaoFinanceiraService;

        public TransacaoFinanceiraController(ITransacaoFinanceiraService transacaoFinanceiraService)
        {
            _transacaoFinanceiraService = transacaoFinanceiraService;
        }


        public ActionResult Index()
        {
            try
            {
                string UserId = User.Identity.GetUserId();

                int mes = DateTime.Now.Month;
                int ano = DateTime.Now.Year;

                TransacaoFinanceiraViewModel vm = _transacaoFinanceiraService.GetIndex(UserId, mes, ano );

                return View(vm);
            }
            catch (Exception e)
            {
                var log = LogManager.GetLogger(typeof(TransacaoFinanceiraController));
                log.Error(e.ToString());
            }

            return View();
        }
    }
}