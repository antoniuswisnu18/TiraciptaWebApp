using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TiraciptaAPI.Models;

public partial class DbTesWisnuContext : DbContext
{
    public DbTesWisnuContext()
    {
    }

    public DbTesWisnuContext(DbContextOptions<DbTesWisnuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Price> Prices { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<SalesOrder> SalesOrders { get; set; }

    public virtual DbSet<SalesOrderInterface> SalesOrderInterfaces { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Customer");

            entity.Property(e => e.CustId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Price>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Price");

            entity.Property(e => e.Price1)
                .HasColumnType("money")
                .HasColumnName("Price");
            entity.Property(e => e.PriceValidateFrom).HasColumnType("date");
            entity.Property(e => e.PriceValidateTo).HasColumnType("date");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductCode);

            entity.ToTable("Product");

            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesOrder>(entity =>
        {
            entity.HasKey(e => e.SalesOrderNo);

            entity.ToTable("SalesOrder");

            entity.Property(e => e.SalesOrderNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesOrderInterface>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesOrderInterface");

            entity.Property(e => e.Payload)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SalesOrderNo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
