using Livraria.Aplicacao.Interfaces;
using Livraria.Aplicacao.Servicos.Comum;
using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Servico;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Aplicacao.Servicos
{
    public class AplicacaoServicoLivro : AplicacaoServicoComum<Livro>, IAplicacaoServicoLivro
    {
        private readonly IServicoLivros servicoLivros;

        public AplicacaoServicoLivro(IServicoLivros servico) : base(servico)
        {
            servicoLivros = servico;
        }

        public Livro Selecionar(string titulo)
        {
            return Selecionar().Where(l => l.Titulo == titulo).FirstOrDefault();
        }

        public IEnumerable<Livro> Selecionar(bool ordenarPorTitulo = false)
        {
            if (ordenarPorTitulo)
                return Selecionar().OrderBy(l => l.Titulo);
            else
                return Selecionar();
        }
    }
}
