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

        public bool Alterar(Recrutadora recrutadora)
        {
            SqlCommand comando = new BancoDados().ObterConexcao();
            comando.CommandText = "UPDATE recrutadoras SET nome = @NOME, cpf = @CPF, tempo_empresa = @TEMPO_EMPRESA, salario = @SALARIO WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", recrutadora.Nome);
            comando.Parameters.AddWithValue("@CPF", recrutadora.CPF);
            comando.Parameters.AddWithValue("@TEMPO_EMPRESA", recrutadora.TempoEmpresa);
            comando.Parameters.AddWithValue("@SALARIO", recrutadora.Salario);
            comando.Parameters.AddWithValue("@ID", recrutadora.Id);

      
            return comando.ExecuteNonQuery() == 1;
        }
    }
}