using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos.Sessao
{
    public class CreateSessaoDto
    {
        [Required]
        public int FilmeId { get; set; }
    }
}
