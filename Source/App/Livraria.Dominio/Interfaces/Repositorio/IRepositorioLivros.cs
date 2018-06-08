using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Repositorio.Comum;
using System.Collections.Generic;

namespace Livraria.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioLivros : IRepositorioComum<Livro>
    {
        Livro Selecionar(string titulo);
        IEnumerable<Livro> Selecionar(bool ordenarPorNome = false);
    }
}
