using biblioteca_virtual.Models;

namespace biblioteca_virtual.ViewModels
{
    public class DetailsVM
    {
        public Livro Anterior { get; set; }
        public Livro Atual { get; set; }
        public Livro Proximo { get; set; }
    }
}

