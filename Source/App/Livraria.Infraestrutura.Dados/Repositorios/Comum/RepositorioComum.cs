using Livraria.Dominio.Interfaces.Repositorio.Comum;
using Livraria.Infraestrutura.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Livraria.Infraestrutura.Dados.Repositorios.Comum
{
    public abstract class RepositorioComum<TipoEntidade> : IRepositorioComum<TipoEntidade> where TipoEntidade : class
    {
        private readonly BancoDados _contexto;
        private DbSet<TipoEntidade> _entidade;

        public RepositorioComum(BancoDados contextoBanco)
        {
            _contexto = contextoBanco;
            _entidade = contextoBanco.Set<TipoEntidade>();
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
        // ~RepositorioBasico() {
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

        public void Adicionar(TipoEntidade entidade)
        {
            if (entidade == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entidade.Add(entidade);
            _contexto.SaveChanges();
        }

        public void Atualizar(TipoEntidade entidade)
        {
            if (entidade == null)
            {
                throw new ArgumentNullException("entity");
            }
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Remover(TipoEntidade entidade)
        {
            if (entidade == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entidade.Remove(entidade);
            _contexto.SaveChanges();
        }

        public IEnumerable<TipoEntidade> Selecionar()
        {
            return _entidade.AsEnumerable();
        }

        public TipoEntidade Selecionar(int id)
        {
            return _entidade.Find(id);
        }       
    }
}