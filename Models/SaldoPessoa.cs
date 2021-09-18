using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoCunha.Models
{
    public class SaldoPessoa


    {
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
