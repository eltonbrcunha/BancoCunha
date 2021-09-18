using System;
using System.ComponentModel.DataAnnotations;

namespace BancoCunha.Models
{
    public class MovimentacaoBancaria
    {
        [Key]
        public int IdMovimentacaoBancaria { get; set; }
        public string TipoMovimentacao { get; set; }
        public decimal ValorMovimentacao{ get; set; }
        public DateTime DataMovimentacao{ get; set; }

        public string NumeroAgencia{ get; set; }
        public int NumeroConta{ get; set; }
        public string AutenticacaoMovimentacao{ get; set; }

    }
}
