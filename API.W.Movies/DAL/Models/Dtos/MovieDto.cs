using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la película es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre no puede contener más de 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La duración es obligatoria.")]
        public int Duration { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "La clasificación es obligatoria.")]
        [MaxLength(10, ErrorMessage = "La clasificación no puede contener más de 10 caracteres.")]
        public string Clasification { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}

