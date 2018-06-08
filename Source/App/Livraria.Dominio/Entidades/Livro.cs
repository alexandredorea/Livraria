using Livraria.Dominio.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Dominio.Entidades
{
    public class Livro : EntidadeComum<int>
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
