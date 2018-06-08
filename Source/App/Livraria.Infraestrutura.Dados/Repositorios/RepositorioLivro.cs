using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Repositorio;
using Livraria.Infraestrutura.Dados.Contexto;
using Livraria.Infraestrutura.Dados.Repositorios.Comum;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Infraestrutura.Dados.Repositorios
{
    public class RepositorioLivro : RepositorioComum<Livro>, IRepositorioLivros
    {
        public RepositorioLivro(BancoDados contextoBanco) : base(contextoBanco)
        {
        }

        public Livro Selecionar(string titulo)
        {
            return Selecionar().Where(l => l.Titulo == titulo).FirstOrDefault();
        }

        public IEnumerable<Livro> Selecionar(bool ordenarPorTitulo = false)
        {
            if (ordenarPorTitulo)
                return Selecionar().OrderBy(l => l.Titulo);
            else
                return Selecionar();
        }
    }
}
