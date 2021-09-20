using BancoCunha.Data;
using BancoCunha.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace BancoCunha.Controllers
{


    public class HomeController : Controller
    {
        private MySqlContext _context;

        public HomeController(MySqlContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string q, int y)
        {
            //Guardando na sessão Agência e Conta
            HttpContext.Session.SetString("SessionAgencia",q);
            HttpContext.Session.SetInt32("SessionConta", y);


            var innerjoin = from p in _context.Pessoa
                            join c in _context.Conta on p.IdPessoa equals c.IdPessoa
                            join s in _context.SaldoPessoa on p.IdPessoa equals s.IdPessoa
                            where c.NumeroAgencia == q && c.NumeroConta == y
                            select (new Conta
                            (
                                
                                 c.IdConta,
                                 c.NumeroConta,
                                 c.DataAbertura,
                                 c.IdPessoa,
                                 c.NumeroAgencia,
                                 new Pessoa
                                   (
                                    p.NomePessoa,
                                    p.DocumentoPessoa,
                                    p.TipoPessoa
                          

                                 ),                            
                                 new SaldoPessoa
                                 {
                                    ValorSaldo=s.ValorSaldo
                                 }
                                
                            ));
                             
            if (await innerjoin.AnyAsync())
            {

                //Consumir a API de envio de e-mail
                //string URI = "https://localhost:44324/api/email/send";
                //Email email = new Email();
                //email.ToEmail = "eltonbrcunha@gmail.com";
                //email.Subject = "Consumindo API";
                //email.Body = "Consumido com sucesso";

                //using (var client = new HttpClient())
                //{
                //    var serializedProduto = JsonConvert.SerializeObject(email);
                //    var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                //    var result = await client.PostAsync(URI, content);
                //}



                HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(innerjoin));

                return View("ClienteLogado", innerjoin.ToList());
            }
            else
            {
                TempData["Msg"] = "Dados incorretos, tente novamente.";
                return RedirectToAction("Index");

            }
        }

        [HttpGet]
        public IActionResult Autenticar()
        {

            return View();
        }


        [HttpGet]
        public IActionResult ClienteLogado()
        {
            return View();

        }

        [HttpGet]
        public IActionResult MovimentacaoBancaria()
        {

            return View();

        }

        [Route("Home/MovimentacaoBancaria")]
        [HttpPost]
        public IActionResult MovimentacaoBancaria(string numAgencia, int numConta, decimal valorMovimentacao)
        {



            var result = (from c in _context.Conta
                          join p in _context.Pessoa on c.IdPessoa equals p.IdPessoa
                          where c.NumeroAgencia == numAgencia && c.NumeroConta == numConta
            select new Conta
                         {
                             NumeroConta = c.NumeroConta,
                             NumeroAgencia = c.NumeroAgencia,

                             Pessoa = new Pessoa
                             (
                                p.NomePessoa
                             ),
                         }).First().ToString();

            if (result.Any())
            {
                try
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (i == 0)
                        {
                            var item = new MovimentacaoBancaria()
                            {


                                TipoMovimentacao = "D",
                                ValorMovimentacao = valorMovimentacao,
                                DataMovimentacao = DateTime.Now,
                                NumeroAgencia = "0001",
                                NumeroConta = 12345,
                                AutenticacaoMovimentacao = "AUTEN" + DateTime.Now.Hour.ToString() + numConta + DateTime.Now.Second.ToString()
                            };

                            _context.Add(item);
                            _context.SaveChanges();
                        }
                        else
                        {
                            var item = new MovimentacaoBancaria()
                            {


                                TipoMovimentacao = "C",
                                ValorMovimentacao = valorMovimentacao,
                                DataMovimentacao = DateTime.Now,
                                NumeroAgencia = numAgencia,
                                NumeroConta = numConta,
                                AutenticacaoMovimentacao = "AUTEN" + DateTime.Now.Hour.ToString()
                            };

                            _context.Add(item);
                            _context.SaveChanges();
                        }
                    }

                }
                catch (Exception ex)
                {

                    return View(ex.ToString());
                }

                TempData["Msg"] = "Valor Transferido R$:" + valorMovimentacao.ToString();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Msg"] = "Dados incorretos, informe novamente.";
                return View();
            }


        }

        private IEnumerable<string> GetAllMembers(Type type)
        {

            var query =
                from member in type.GetMembers()
                select member.GetType() + " " + member.ToString();

            return query;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
