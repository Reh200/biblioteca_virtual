using System.Collections.Generic;
using biblioteca_virtual.Models; // Ajuste o namespace conforme necessário

namespace biblioteca_virtual.ViewModels
{
    public class HomeVM
    {
        public List<Genero> Generos { get; set; }
        public List<Livro> Livros { get; set; }
    }
}


/*
using biblioteca_virtual.Models;

namespace biblioteca_virtual.ViewModels
{
    public class HomeVM
    {
        public List<Genero> Generos { get; set; }
        public List<Livro> Livros { get; set; }
    }
}*/