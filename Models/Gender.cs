using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Gender")]
    public class Gender
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor, informe o Nome")]
        [StringLength(15, ErrorMessage = "O nome deve possuir no máximo 15 caracteres")]
        public string Name { get; set; } = string.Empty;
    }
}