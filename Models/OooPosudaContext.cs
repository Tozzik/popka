using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace popka.Models;

public partial class OooPosudaContext : DbContext
{
    public OooPosudaContext()
    {
    }

    public OooPosudaContext(DbContextOptions<OooPosudaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<PickupPoint> PickupPoints { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=OOO_Posuda;Username=postgres;Password=123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("full_name");
            entity.Property(e => e.OrderArticle)
                .HasMaxLength(255)
                .HasColumnName("order_article");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.OrderDelivery).HasColumnName("order_delivery");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Новый'::character varying")
                .HasColumnName("status");

            entity.HasOne(d => d.AddressNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Address)
                .HasConstraintName("orders_address_fkey");
        });

        modelBuilder.Entity<PickupPoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pickup_points_pkey");

            entity.ToTable("pickup_points");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adress)
                .HasMaxLength(255)
                .HasColumnName("adress");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Article).HasName("products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Article)
                .HasMaxLength(100)
                .HasColumnName("article");
            entity.Property(e => e.Category)
                .HasMaxLength(150)
                .HasColumnName("category");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(150)
                .HasColumnName("manufacturer");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
            entity.Property(e => e.Photo)
                .HasDefaultValueSql("'picture.png'::text")
                .HasColumnName("photo");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Supplier)
                .HasMaxLength(100)
                .HasColumnName("supplier");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasDefaultValueSql("'шт.'::character varying")
                .HasColumnName("unit");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("users");

            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("full_name");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .HasColumnName("role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
