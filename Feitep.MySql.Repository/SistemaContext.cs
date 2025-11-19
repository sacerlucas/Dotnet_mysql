using Feitep.MySql.Models;
using Microsoft.EntityFrameworkCore;

namespace Feitep.MySql.Repository;
    public class SistemaContext :DbContext
{
    public SistemaContext(DbContextOptions<SistemaContext>options)
    : base(options)
    {
        
    }
        public DbSet<Cliente>? Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(cliente => cliente.Id);

            entity.Property(Cliente => Cliente.Id)
            .HasColumnName("")
            .ValueGeneratedOnAdd();

            entity.Property(Cliente => Cliente.Nome)
            .HasColumnName("nome")
            .IsRequired()
            .HasMaxLength(255);

            entity.Property(Cliente => Cliente.DataNascimento)
            .HasColumnName("dt_nascimento")
            .HasColumnType("datetime")
            .IsRequired();

        });
    }
    }
