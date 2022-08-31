using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Generation")]
    public class Generation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor, informe o Nome")]
        [StringLength(20, ErrorMessage = "O nome deve possuir no máximo 20 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Cor de Exibição")]
        [Required(ErrorMessage = "Por favor, informe a Cor")]
        [StringLength(1, ErrorMessage = "A Cor deve possuir no máximo 1 caracter")]
        public string Midia { get; set; } = string.Empty;
    }
}