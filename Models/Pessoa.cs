using System.ComponentModel.DataAnnotations;
namespace BancoCunha.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string NomePessoa { get; set; }

        [Required(ErrorMessage = "Informe o seu documento CPF")]
        public string DocumentoPessoa { get; set; }

        public string TipoPessoa { get; set; }
    }

}
