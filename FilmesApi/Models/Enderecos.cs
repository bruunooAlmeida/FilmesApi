using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Enderecos
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        
        public int Numero { get; set; }

        public virtual Cinemas Cinema { get; set; }

    }
}
