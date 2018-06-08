using Livraria.Dominio.Entidades;
using Livraria.Infraestrutura.Dados.ConfiguracaoEntidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace Livraria.Infraestrutura.Dados.Contexto
{
    public class BancoDados : DbContext
    {

        public BancoDados(DbContextOptions<BancoDados> options) : base(options)
        {
        }

        public BancoDados() : base()
        {
        }

        public DbSet<Livro> Livros { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //Obtem a configuração do app settings
        //    var configuracao = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //        .Build();

        //    //Define o banco de dados que será usado
        //    optionsBuilder.UseSqlServer(configuracao.GetConnectionString("ConnectionString"));

        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfiguracaoLivro());
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entidade in ChangeTracker.Entries().Where(propriedade => propriedade.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entidade.State == EntityState.Added)
                {
                    entidade.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entidade.State == EntityState.Modified)
                {
                    entidade.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
