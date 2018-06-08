using Livraria.Dominio.Entidades;
using Livraria.Dominio.Interfaces.Repositorio;
using Livraria.Dominio.Interfaces.Servico;
using Livraria.Dominio.Servicos.Comum;
using System.Collections.Generic;

namespace Livraria.Dominio.Servicos
{
    public class ServicoLivro : ServicosComum<Livro>, IServicoLivros
    {
        private readonly IRepositorioLivros repositorio;

        public ServicoLivro(IRepositorioLivros contexto) : base(contexto)
        {
            repositorio = contexto;
        }

        #region Métodos de CRUD especifico

        public IEnumerable<Livro> Selecionar(bool ordenarPorNome = false)
        {
            return repositorio.Selecionar(ordenarPorNome);
        }

        public Livro Selecionar(string titulo)
        {
            return repositorio.Selecionar(titulo);
        }

        #endregion
    }
}
