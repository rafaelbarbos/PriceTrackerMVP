using Microsoft.EntityFrameworkCore;
using PriceTracker.Domain.Entities;
using PriceTracker.Domain.Enums;

namespace PriceTracker.Data.Context{
    public class PriceTrackerContext : DbContext{
        // Conjuntos de entidades que serão mapeados na tabelas
        public DbSet<Product> Products {get; set;}
        public DbSet<PriceHistory> PriceHistories {get; set;}
        public DbSet<NotificationSettings> NotificationSettings {get; set;}
        public DbSet<NotificationLog> NotificationLogs {get; set;}

        // Método construtor que recebe as opções de configuração do contexto
        // e repassa para a classe base (DbContext)
        public PriceTrackerContext(DbContextOptions<PriceTrackerContext> options)
            : base(options){

            }

        // Método que será chamado quando o contexto for configurado
        protected override void OodelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            // Configuração da chave primária da entidade Product
            modelBuilder.Entity<Product>(entity =>{
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Url).IsRequired();
                entity.Property(e => e.CurrentPrice).HasPrecision(18, 2);
                entity.Property(e => e.TargetPrice).HasPrecision(18, 2);
                entity.Property(e => e.LowestRecordedPrice).HasPrecision(18, 2);
                
                // Relacionamento com histórico de preços
                entity.HasMany(e => e.PriceHistory)
                      .WithOne(p => p.Product)
                      .HasForeignKey(p => p.ProductId);
            });

            // Configurações para outras entidades podem ser adicionadas similarmente
            modelBuilder.Entity<NotificationSettings>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.UserId).IsRequired();
                entity.Property(e => e.ContactInfo).IsRequired();
            });
        }
    }
}