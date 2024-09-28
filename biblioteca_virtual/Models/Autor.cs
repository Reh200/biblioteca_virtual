using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace biblioteca_virtual.Models
{
    [Table("Autores")]
    public class Autor
    {
        [Key]
        public int Id_autor { get; set; }  

        [Required(ErrorMessage = "Informe o autor")]
        [StringLength(30, ErrorMessage = "O Nome do autor deve possuir no máximo 30 caracteres")]
        public string Nome_autor { get; set; }
   }
}
