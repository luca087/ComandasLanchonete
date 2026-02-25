using ComandasLanchonete.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ComandasLanchonete.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<ComandaDALModel> Comandas {  get; set; }
        public DbSet<ProdutoDALModel> Produtos {  get; set; }
        public DbSet<UserDALModel> Usuarios {  get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../ComandasLanchonete.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComandaDALModel>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id)
                .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ProdutoDALModel>(entity =>
            {
                entity.HasOne(x => x.Comanda)
                .WithMany(x => x.Produtos)
                .HasForeignKey(x => x.ComandaId);

                entity.HasKey(x=>x.Id);
                entity.Property(x => x.Id)
                .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UserDALModel>(entity =>
            {
                entity.HasKey(x => x.Id); 
                entity.Property(x => x.Id).ValueGeneratedOnAdd();

                entity.HasIndex(x=>x.Login)
                .IsUnique();
            });
        }
    }
}
