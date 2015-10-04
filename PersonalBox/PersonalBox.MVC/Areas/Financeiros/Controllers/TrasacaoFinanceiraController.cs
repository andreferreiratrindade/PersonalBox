using log4net;
using PersonalBox.MVC.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalBox.MVC.Areas.Financeiros.Controllers
{
    public class TrasacaoFinanceiraController : Controller
    {
        private readonly ITransacaoFianceiraService _transacaoFinanceiraService;

        public TrasacaoFinanceiraController(ITransacaoFianceiraService transacaoFinanceiraService)
        {
            _transacaoFinanceiraService = transacaoFinanceiraService;
        }


        public ActionResult Index()
        {
            try
            {




            }catch(Exception e)
            {
                var log = LogManager.GetLogger(typeof(TrasacaoFinanceiraController));
                log.Error(e.ToString());
            }

            return View();
        }
    }
}