using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPeople2.Models
{
    public enum SexType
    {
        Female = 0,
        Male = 1
    }
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "El nombre debe contener entre 5 a 60 caracteres")]
        [Display(Name = "Nombre completo de la persona")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        public SexType Sex { get; set; }
        [Display(Name = "Pasa tiempo")]
        public string Hobbie { get; set; }


    }
}
