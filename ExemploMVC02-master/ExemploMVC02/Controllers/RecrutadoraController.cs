﻿using ExemploMVC02.Models;
using ExemploMVC02.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC02.Controllers
{
    public class RecrutadoraController : Controller
    {
        // GET: Recrutadora
        public ActionResult Index()
        {
            List<Recrutadora> recrutadoras = new RecrutadoraRepositorio().ObterTodos();
            ViewBag.Recrutadoras = recrutadoras;
            return View();
        }
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }


        public ActionResult Excluir(int id)
        {
            bool apagado = new RecrutadoraRepositorio().Excluir(id);
            return null;
        }
        public ActionResult Store(Recrutadora recrutadora)
        {
            int id = new RecrutadoraRepositorio().Cadastrar(recrutadora);


            return null;
        }

        public ActionResult Update()
        {
            return null;
        }
    }
}