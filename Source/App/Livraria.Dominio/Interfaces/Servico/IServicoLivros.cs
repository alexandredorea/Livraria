using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Servico.Comum;
using System.Collections.Generic;

namespace Livraria.Dominio.Interfaces.Servico
{
    interface IServicoLivros : IServicoComum<Livro>
    {
        Livro Selecionar(string titulo);
        IEnumerable<Livro> Selecionar(bool ordenarPorNome = false);
    }
}
