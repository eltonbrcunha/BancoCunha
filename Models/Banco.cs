using System.ComponentModel.DataAnnotations;

namespace BancoCunha.Models
{
    public class Banco  
    {

        public Banco( string codbanco, string nomebanco)
        {
            Codbanco = codbanco;
            Nomebanco = "Banco Cunha";
        }

        [Key]
        public int Idbanco { get; set; }

        [Required(ErrorMessage = "O Código do banco é obrigatório")]
        public string Codbanco { get; private set; }

        [Required(ErrorMessage="O nome do banco é obrigatório")]
        public string  Nomebanco { get; private set; }
        
    }
}
