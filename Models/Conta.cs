
using System;
using System.ComponentModel.DataAnnotations;

namespace BancoCunha.Models
{
    public class Conta 
    {
        public Conta()
        {

        }

        public Conta(int idconta , int numeroConta, DateTime dataAbertura, int idPessoa, string numeroAgencia, Pessoa pessoa, SaldoPessoa saldoPessoa)
        {
            IdConta = idconta;
            NumeroConta = numeroConta;
            DataAbertura = dataAbertura;
            IdPessoa = idPessoa;
            NumeroAgencia = numeroAgencia;
            this.Pessoa= pessoa;
            SaldoPessoa = saldoPessoa;
        }

     


       [Key]
        public int IdConta { get; set; }

        public int NumeroConta { get; set; }
        public DateTime DataAbertura{ get; set; }
        public int IdPessoa { get; set; }
        public string NumeroAgencia { get; set; }

        public Pessoa Pessoa { get; set; }
        public SaldoPessoa SaldoPessoa{ get; set; }


    }
}
