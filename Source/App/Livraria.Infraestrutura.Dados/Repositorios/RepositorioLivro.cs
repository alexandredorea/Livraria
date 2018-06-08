using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Repositorio;
using Livraria.Infraestrutura.Dados.Contexto;
using Livraria.Infraestrutura.Dados.Repositorios.Comum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Infraestrutura.Dados.Repositorios
{
    public class RepositorioLivro : RepositorioComum<Livro>, IRepositorioLivros
    {
        public RepositorioLivro(BancoDados contextoBanco) : base(contextoBanco)
        {
        }

        public Livro Selecionar(string titulo)
        {
            throw new NotImplementedException();
            //return contextoBanco.Livros.Where(l => l.Titulo == titulo);
        }

        public IEnumerable<Livro> Selecionar(bool ordenarPorNome = false)
        {
            throw new NotImplementedException();
        }
    }
}
