using Livraria.Dominio.Interfaces.Repositorio;
using Livraria.Dominio.Interfaces.Servico;
using Livraria.Dominio.Servicos;
using Livraria.Infraestrutura.Dados.Contexto;
using Livraria.Infraestrutura.Dados.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.Infraestrutura.Transversal.InjecaoDependencia
{
    public class IDConteiner
    {
        public static void RegisterDependencies(IServiceCollection servicos)
        {
            servicos.AddScoped<BancoDados>();
            servicos.AddTransient<IRepositorioLivros, RepositorioLivro>();
            servicos.AddTransient<IServicoLivros, ServicoLivro> ();
        }
    }
}
