using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Allen20480.Controllers
{
    public class ContatoController : Controller
    {
        //
        // GET: /Contato/

        public ActionResult Index()
        {
            return View();
        }

        //Utilizo este attribute "HttpPost" para não passar o nome, email pela URL
        [HttpPost]
        public ActionResult EnviaMensagem(string nome, string email, string mensagem)
        {
            //Esperar 1 segundo
            Thread.Sleep(1000);

            //Retorna uma mensagem de "OK"
            return Json(new { Message = "OK" });
        }

    }
}
