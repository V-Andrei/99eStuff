namespace _99eStuff.Data.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DetailedProduct> DetailedProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailedProduct>()
                .Property(e => e.Material)
                .IsUnicode(false);

            modelBuilder.Entity<DetailedProduct>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<DetailedProduct>()
                .Property(e => e.Detail1)
                .IsUnicode(false);

            modelBuilder.Entity<DetailedProduct>()
                .Property(e => e.Detail2)
                .IsUnicode(false);

            modelBuilder.Entity<DetailedProduct>()
                .Property(e => e.Detail3)
                .IsUnicode(false);

            modelBuilder.Entity<DetailedProduct>()
                .Property(e => e.Detail4)
                .IsUnicode(false);

            modelBuilder.Entity<DetailedProduct>()
                .Property(e => e.Detail5)
                .IsUnicode(false);

            modelBuilder.Entity<DetailedProduct>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<DetailedProduct>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.DetailedProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.NameProduct)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.CurentPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.OldPrice)
                .HasPrecision(19, 4);
        }
    }
}
