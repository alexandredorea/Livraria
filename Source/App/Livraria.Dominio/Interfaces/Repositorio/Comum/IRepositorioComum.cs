using System;
using System.Collections.Generic;

namespace Livraria.Dominio.Interfaces.Repositorio.Comum
{
    public interface IRepositorioComum<TipoEntidade> : IDisposable where TipoEntidade : class
    {
        void Adicionar(TipoEntidade entidade);
        void Atualizar(TipoEntidade entidade);
        void Remover(TipoEntidade entidade);
        IEnumerable<TipoEntidade> Selecionar();
        TipoEntidade Selecionar(int id);
    }
}
