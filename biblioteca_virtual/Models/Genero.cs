using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace biblioteca_virtual.Models
{
    [Table("Generos")]
    public class Genero
    {
        [Key]
        public int Id_genero { get; set; }  

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
        public string Nome_genero { get; set; }
   }
}

