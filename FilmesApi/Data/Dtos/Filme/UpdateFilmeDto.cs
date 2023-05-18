using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos.Filme;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O titulo do Filme é Obrigatorio")]
    [StringLength(30)]
    public string Titulo { get; set; }

    [Required(AllowEmptyStrings = true)]

    public string Diretor { get; set; }


    [Required(ErrorMessage = "Titulo do Filme é obrigatorio")]
    [StringLength(20, ErrorMessage = "O tamanho deve ser de ")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "Duração do Filme Obrigatorio")]
    [Range(1, 600)]
    public int Duracao { get; set; }
}
