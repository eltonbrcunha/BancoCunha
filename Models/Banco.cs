using System.ComponentModel.DataAnnotations;

namespace BancoCunha.Models
{
    public class Banco  
    {
        [Key]
        public int Idbanco { get; set; }

        [Required(ErrorMessage = "O Código do banco é obrigatório")]
        public string Codbanco { get; set; }

        [Required(ErrorMessage="O nome do banco é obrigatório")]
        public string  Nomebanco { get; set; }
        


    }
}
