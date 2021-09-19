using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoCunha.Models
{
    public class SaldoPessoa

    {
        public SaldoPessoa()
        {


        }


        public SaldoPessoa(Pessoa pessoa, int idPessoa, Conta conta, int idConta, int numeroConta, string numeroAgencia, decimal valorSaldo)
        {
            Pessoa = pessoa;
            IdPessoa = idPessoa;
            Conta = conta;
            IdConta = idConta;
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
            ValorSaldo = valorSaldo;
        }

        [Key]
        public int IdSaldo { get; set; }

        [ForeignKey("IdPessoa")]
        public Pessoa Pessoa { get; set; }
        public int IdPessoa { get; set; }

        [ForeignKey("IdConta")]
        public Conta Conta { get; set; }
        public int IdConta { get; set; }


        public int NumeroConta { get; set; }
        public string NumeroAgencia { get; set; }
        public decimal ValorSaldo { get; set; }



    }
}
