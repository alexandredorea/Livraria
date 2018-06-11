using Livraria.Aplicacao.Interfaces.Comum;
using Livraria.Dominio.Entidades;
using System.Collections.Generic;

namespace Livraria.Aplicacao.Interfaces
{
    public interface IAplicacaoServicoLivro : IAplicacaoServicoComum<Livro>
    {
        Livro Selecionar(string titulo);
        IEnumerable<Livro> Selecionar(bool ordenarPorTitulo = false);
    }
}
