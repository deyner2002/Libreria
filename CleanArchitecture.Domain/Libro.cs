﻿using CleanArchitecture.Domain.Common;
using System.ComponentModel.DataAnnotations;
namespace CleanArchitecture.Domain
{
    public class Libro: BaseDomainModel
    {
        [Required]
        [StringLength(maximumLength: 250)]
        public string Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; }
    }
}
