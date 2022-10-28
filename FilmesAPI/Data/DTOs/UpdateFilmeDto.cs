using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo é obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório!")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O tamanho máximo do gênero é de {1} caracteres!")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter de no mínimo {1} minuto e no máximo {2} minutos!")]
        public int Duracao { get; set; }
    }
}
