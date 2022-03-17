﻿using System.ComponentModel.DataAnnotations;
namespace CleanArchitecture.Domain
{
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 120, ErrorMessage = "El campo {0} no debe de tener más de {1} carácteres")]
        public string Nombre { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; }
    }
}
