using BancoCunha.Data;
using BancoCunha.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace BancoCunha.Controllers
{
    public class PessoaController : Controller
    {
        private readonly MySqlContext _context;

        public PessoaController(MySqlContext context)
        {
            _context = context;
        }


        [Route("Pessoa/AbrirConta")]
        [HttpPost]
        public async Task<IActionResult> AbrirConta(Pessoa p)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var todoitem = new Pessoa
                    (
                         p.NomePessoa,
                         p.DocumentoPessoa,
                         p.TipoPessoa = "F"


                    );

                    _context.Add(p);
                    await _context.SaveChangesAsync();


                    //Conta Bancária
                    var contaBancaria = new Conta
                    {
                        NumeroConta = Convert.ToInt32(p.DocumentoPessoa.Substring(0, 5)),
                        DataAbertura = DateTime.Now,
                        IdPessoa = p.IdPessoa,
                        NumeroAgencia = "0001"

                    };
                    _context.Add(contaBancaria);
                    await _context.SaveChangesAsync();
                    //Conta Bancária

                    //Adicionando o saldo inicial
                    var saldo = new SaldoPessoa()
                    {
                        ValorSaldo      = 1000,
                        IdConta         = contaBancaria.IdConta,
                        IdPessoa        = p.IdPessoa,
                        NumeroAgencia   = contaBancaria.NumeroAgencia,
                        NumeroConta     = contaBancaria.NumeroConta


                    };
                    _context.Add(saldo);
                    await _context.SaveChangesAsync();
              


                    //Carregando os dados do Correntist e da Conta na VIEW
                    var conta = await _context.Conta.FirstOrDefaultAsync(m => m.IdPessoa == p.IdPessoa);

                    if (conta == null)
                    {
                        return NotFound();
                    }

                    Conta pessoaConta = new Conta()
                    {
                        IdConta = conta.IdConta,
                        NumeroConta = conta.NumeroConta,
                        DataAbertura = conta.DataAbertura,
                        IdPessoa = p.IdPessoa,
                        NumeroAgencia = conta.NumeroAgencia,

                        Pessoa = new Pessoa
                        (
                             p.NomePessoa,
                             p.DocumentoPessoa,
                             p.TipoPessoa

                        )

                    };

                    return View("ContaCriada", pessoaConta);
                }
                catch (Exception ex)
                {
                    return View("Error", ex);
                }
            }
            else
            {
                return View("Error");
            }


        }

        [Route("Pessoa/AbrirConta")]
        [HttpGet]
        public IActionResult AbrirConta()
        {
            return View("AbrirConta");
        }

        [Route("Pessoa/ContaCriada")]
        [HttpGet]
        public IActionResult ContaCriada()
        {
            return View();
        }

    }
}
