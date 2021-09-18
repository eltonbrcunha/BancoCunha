
using System;
using System.ComponentModel.DataAnnotations;

namespace BancoCunha.Models
{
    public class Conta 
    {
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
