using System;
using System.Collections.Generic;

namespace Livraria.Dominio.Interfaces.Servico.Comum
{
    public interface IServicoComum<TipoEntidade> : IDisposable where TipoEntidade : class
    {
        void Adicionar(TipoEntidade entidade);
        void Atualizar(TipoEntidade entidade);
        void Remover(TipoEntidade entidade);
        IEnumerable<TipoEntidade> Selecionar();
        TipoEntidade Selecionar(int id);
    }
}
