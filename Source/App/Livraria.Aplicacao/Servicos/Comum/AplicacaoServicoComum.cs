using Livraria.Aplicacao.Interfaces.Comum;
using Livraria.Dominio.Interfaces.Servico.Comum;
using System.Collections.Generic;

namespace Livraria.Aplicacao.Servicos.Comum
{
    public class AplicacaoServicoComum<TipoEntidade> : IAplicacaoServicoComum<TipoEntidade> where TipoEntidade : class
    {
        private readonly IServicoComum<TipoEntidade> servicoComum;

        public AplicacaoServicoComum(IServicoComum<TipoEntidade> servico)
        {
            servicoComum = servico;
        }

        public void Adicionar(TipoEntidade entidade)
        {
            servicoComum.Adicionar(entidade);
        }

        public void Atualizar(TipoEntidade entidade)
        {
            servicoComum.Atualizar(entidade);
        }

        public void Dispose()
        {
            servicoComum.Dispose();
        }

        public void Remover(TipoEntidade entidade)
        {
            servicoComum.Remover(entidade);
        }

        public IEnumerable<TipoEntidade> Selecionar()
        {
            return servicoComum.Selecionar();
        }

        public TipoEntidade Selecionar(int id)
        {
            return servicoComum.Selecionar(id);
        }
    }
}
