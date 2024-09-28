using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace biblioteca_virtual.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        public int Id_livro { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(100)]

        public string titulo { get; set; }

        public string sinopse { get; set; }

        public int Id_autor { get; set; }
        
        [ForeignKey("Id_autor")]
        public Autor Autor { get; set; }

        public int Id_genero { get; set; }
        [ForeignKey("Id_genero")]
        public Genero Genero { get; set; }

    }
}


