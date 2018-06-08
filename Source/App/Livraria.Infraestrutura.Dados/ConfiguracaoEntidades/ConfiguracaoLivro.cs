using Livraria.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Infraestrutura.Dados.ConfiguracaoEntidades
{
    public class ConfiguracaoLivro : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            //Nome da tabela
            builder.ToTable("Livros");

            //Configurações: PK, IX, Nomes, etc.
            builder.HasKey(c => c.Id)
                .HasName("PK_Livros_LivroId")
                .ForSqlServerIsClustered();

            builder.HasIndex(c => c.Id)
                .HasName("IX_Livros_LivroId")
                .IsUnique();

            //Definição das propriedades no banco de dados
            builder.Property(c => c.Id)
                .HasColumnName("LivroId");

            builder.Property(c => c.Titulo)
                .HasColumnName("Titulo")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(c => c.Autor)
                .HasColumnName("Autor")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(c => c.DataCadastro)
                .HasColumnName("DataCadastro")
                .IsRequired();
        }
    }
}
