using Livraria.Dominio.Interfaces.Repositorio.Comum;
using Livraria.Dominio.Interfaces.Servico.Comum;
using System;
using System.Collections.Generic;

namespace Livraria.Dominio.Servicos.Comum
{
    public class ServicosComum<TipoEntidade> : IServicoComum<TipoEntidade> where TipoEntidade : class
    {
        IRepositorioComum<TipoEntidade> repositorio;

        public ServicosComum(IRepositorioComum<TipoEntidade> contexto)
        {
            repositorio = contexto;
        }

        #region IDisposable Support
        private bool disposedValue = false; // Para detectar chamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: descartar estado gerenciado (objetos gerenciados).
                }

                // TODO: liberar recursos não gerenciados (objetos não gerenciados) e substituir um finalizador abaixo.
                // TODO: definir campos grandes como nulos.

                disposedValue = true;
            }
        }

        // TODO: substituir um finalizador somente se Dispose(bool disposing) acima tiver o código para liberar recursos não gerenciados.
        // ~ServicosComum() {
        //   // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
        //   Dispose(false);
        // }

        // Código adicionado para implementar corretamente o padrão descartável.
        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
            Dispose(true);
            // TODO: remover marca de comentário da linha a seguir se o finalizador for substituído acima.
            // GC.SuppressFinalize(this);
        }
        #endregion

        #region Métodos de CRUD básico

        public void Adicionar(TipoEntidade entidade)
        {
            repositorio.Adicionar(entidade);
        }

        public void Atualizar(TipoEntidade entidade)
        {
            repositorio.Atualizar(entidade);
        }

        public void Remover(TipoEntidade entidade)
        {
            repositorio.Remover(entidade);
        }

        public IEnumerable<TipoEntidade> Selecionar()
        {
            return repositorio.Selecionar();
        }

        public TipoEntidade Selecionar(int id)
        {
            return repositorio.Selecionar(id);
        }

        #endregion
    }
}
