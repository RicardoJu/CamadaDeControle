using CamadaDeControle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamadaDeControle.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
		public ActionResult Lista()
		{
			K19Context ctx = new K19Context();
			return View(ctx.Produtos);
		}

		[HttpGet]
		public ActionResult Cadastra()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Cadastra(Produto p)
		{
			

			K19Context ctx = new K19Context();
			ctx.Produtos.Add(p);
			ctx.SaveChanges();

			TempData["Mensagem"]="Produto cadastrado com sucesso!";

			return RedirectToAction("Lista");
        }
    }
}