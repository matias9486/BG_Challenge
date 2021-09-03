using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Models
{
    public class Vehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        //Patente/Placa (texto 8 caracretes)
        [Display(Name = "Patente/Placa")]
        [Required(ErrorMessage = "{0} es requerido.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "La {0} debe contener {1} caracteres.")]
        public string Patente { get; set; }

        //Marca (combo con algunos valores predefinidos ej: Fiat, Peugeot, Audi)
        [Display(Name = "Marca")]
        [Required(ErrorMessage = "{0} es requerido.")]
        public string Marca { get; set; }

        //Modelo(texto libre)
        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "{0} es requerido.")]
        public string Modelo { get; set; }

        //Puertas(numérico)                
        [Display(Name = "Puertas")]
        [Required(ErrorMessage = "{0} es requerido.")]
        [Range(1, 5, ErrorMessage = "El valor para {0} debe estar entre {1} y {2}.")]
        public int Puertas { get; set; }

        //Titular/dueño(texto)
        [Display(Name = "Titular/dueño")]
        [Required(ErrorMessage = "{0} es requerido.")]
        public string Titular { get; set; }
    }
}
