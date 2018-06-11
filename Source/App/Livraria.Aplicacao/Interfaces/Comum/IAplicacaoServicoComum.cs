using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Aplicacao.Interfaces.Comum
{
    public interface IAplicacaoServicoComum<TipoEntidade> : IDisposable where TipoEntidade : class
    {
        void Adicionar(TipoEntidade entidade);
        void Atualizar(TipoEntidade entidade);
        void Remover(TipoEntidade entidade);
        IEnumerable<TipoEntidade> Selecionar();
        TipoEntidade Selecionar(int id);
    }
}
