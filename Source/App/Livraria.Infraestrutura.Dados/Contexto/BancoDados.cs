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
            // Garante com que o banco seja criado a partir das classes 
            Database.EnsureCreated();
        }

        public BancoDados() : base()
        {
        }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Obtem a configuração do app settings
            // pegue onde ta a configuração da minha connection string
            // AddJsonFile - faz com que seja geral vai servir para qualquer tipo de sistemas que usam essa arquitetura
            var configuracao = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Verifica se o projeto main possui uma conexão ou uma string connection
            if (!optionsBuilder.IsConfigured)
                //Define o banco de dados que será usado
                optionsBuilder.UseSqlServer(configuracao.GetConnectionString("DefaultConnection"));

            base.OnConfiguring(optionsBuilder);
        }

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