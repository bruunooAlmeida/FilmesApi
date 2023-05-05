using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "O titulo do Filme é Obrigatorio")]
        [StringLength(30)]
        public string Titulo  { get; set; }
        
        [Required (ErrorMessage = "Titulo do Filme é obrigatorio")]
        [MaxLength(20,ErrorMessage = "O tamanho deve ser de ")]
        
        public string Genero  { get; set; }
        
        [Required (ErrorMessage = "Duração do Filme Obrigatorio")]        
        [Range(1, 120)]
        public int    Duracao { get; set; }

        public string Diretor { get; set; }

        public override string ToString()
        {
            return "Titulo: " + this.Titulo + "\n" + "Genero:" + "\n" + this.Genero + "Duracao:" + this.Duracao; 
        }


        public void mostrarInfo()
        {
            Console.WriteLine( this.ToString());
        }
    }
}
