using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Types")]
    public class Types
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor, informe o Nome")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Cor de Exibição")]
        [Required(ErrorMessage = "Por favor, informe a Cor")]
        [StringLength(7, ErrorMessage = "A Cor deve possuir no máximo 7 caracter")]
        public string Cor { get; set; } = string.Empty;
    }
}