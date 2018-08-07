using ExemploMVC02.Database;
using ExemploMVC02.Models;
using ExemploMVC02.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC02.Controllers
{
    public class RecrutadoraController : Controller
    {
        // GET: Recrutadora
        [HttpGet]
        public ActionResult Index()
        {
            List<Recrutadora> recrutadoras = new RecrutadoraRepositorio().ObterTodos();
            ViewBag.Recrutadoras = recrutadoras;
            ViewBag.TituloPagina = "Recrutadoras";
            return View();
        }
        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.TituloPagina = "Rescrutadoras - Cadastro";
            ViewBag.Recrutadora = new Recrutadora();
            return View();
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            Recrutadora recrutadora = new RecrutadoraRepositorio().ObterPeloId(id);
            ViewBag.Recrutadora = recrutadora;
            return View();
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            bool apagado = new RecrutadoraRepositorio().Excluir(id);
            return null;
        }

        [HttpPost]
        public ActionResult Store(Recrutadora recrutadora)
        {

            if (ModelState.IsValid)
            {
            int identificador = new RecrutadoraRepositorio().Cadastrar(recrutadora);
            return RedirectToAction("Editar", new { id = identificador });

            }

            ViewBag.recrutadora = recrutadora;

            return View("Cadastro");


        }

        [HttpPost]
        public ActionResult Update(Recrutadora recrutadora)
        {
            bool alterado = new RecrutadoraRepositorio().Alterar(recrutadora);
            return null;
        }


    }
}