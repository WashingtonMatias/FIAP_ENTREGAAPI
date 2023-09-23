using Fiap.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Data.Context
{
    public class FiapContext : DbContext
    {
        public FiapContext(DbContextOptions<FiapContext> options) : base(options)
        {
        }

        public DbSet<Cadastro> Cadastro { get; set; }

        public DbSet<Tbl_Estabelecimento> Tbl_Estabelecimento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbl_Estabelecimento>()
                .HasKey(e => e.ID_ESTABELECIMENTO); // Define a chave primária
            modelBuilder.Entity<Cadastro>()
                .HasKey(e => e.Id_Cadastro); // Define a chave primária

            // Configurações adicionais do modelo, se necessário
        }
    }
}
