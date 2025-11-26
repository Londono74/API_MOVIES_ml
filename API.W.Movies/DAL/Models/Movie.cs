using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class Movie : AuditBase
    {
        [Required(ErrorMessage = "El nombre de la película es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre no puede contener más de 100 caracteres.")]
        [Display(Name = "Nombre de la película")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La duración es obligatoria.")]
        [Display(Name = "Duración")]
        public int Duration { get; set; }

        [Display(Name = "Descripción")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "La clasificación es obligatoria.")]
        [MaxLength(10, ErrorMessage = "La clasificación no puede contener más de 10 caracteres.")]
        [Display(Name = "Clasificación")]
        public string Clasification { get; set; }
    }
}

