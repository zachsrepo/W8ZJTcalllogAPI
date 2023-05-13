using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;


namespace W8ZJTcalllog.Models;

public partial class FccAmateurContext : DbContext
{
    public FccAmateurContext()
    {
    }
    public FccAmateurContext(DbContextOptions<FccAmateurContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Am> Ams { get; set; }

    public virtual DbSet<En> Ens { get; set; }

    public virtual DbSet<Hd> Hds { get; set; }
    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<HamLog> HamLogs { get; set; }
    public virtual DbSet<Spot> Spots { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Am>(entity =>
        {
            entity.HasKey(e => e.Fccid).HasName("PRIMARY");

            entity.ToTable("am");

            entity.HasIndex(e => e.Callsign, "idx_callsign");

            entity.HasIndex(e => e.Class, "idx_class");

            entity.Property(e => e.Fccid)
                .ValueGeneratedNever()
                .HasColumnName("fccid");
            entity.Property(e => e.Callsign)
                .HasMaxLength(8)
                .HasColumnName("callsign");
            entity.Property(e => e.Class)
                .HasMaxLength(1)
                .HasColumnName("class");
            entity.Property(e => e.Col4)
                .HasMaxLength(1)
                .HasColumnName("col4");
            entity.Property(e => e.Col5)
                .HasMaxLength(2)
                .HasColumnName("col5");
            entity.Property(e => e.Col6)
                .HasMaxLength(3)
                .HasColumnName("col6");
            entity.Property(e => e.FormerCall)
                .HasMaxLength(8)
                .HasColumnName("former_call");
            entity.Property(e => e.FormerClass)
                .HasMaxLength(1)
                .HasColumnName("former_class");
        });

        modelBuilder.Entity<En>(entity =>
        {
            entity.HasKey(e => e.Fccid).HasName("PRIMARY");

            entity.ToTable("en");

            entity.HasIndex(e => e.Callsign, "idx_callsign");

            entity.HasIndex(e => e.Zip, "idx_zip");

            entity.Property(e => e.Fccid)
                .ValueGeneratedNever()
                .HasColumnName("fccid");
            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .HasColumnName("address1");
            entity.Property(e => e.Callsign)
                .HasMaxLength(8)
                .HasColumnName("callsign");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.First)
                .HasMaxLength(50)
                .HasColumnName("first");
            entity.Property(e => e.FullName)
                .HasMaxLength(150)
                .HasColumnName("full_name");
            entity.Property(e => e.Last)
                .HasMaxLength(50)
                .HasColumnName("last");
            entity.Property(e => e.Middle)
                .HasMaxLength(1)
                .HasColumnName("middle");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .HasColumnName("state");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<Hd>(entity =>
        {
            entity.HasKey(e => e.Fccid).HasName("PRIMARY");

            entity.ToTable("hd");

            entity.HasIndex(e => e.Callsign, "idx_callsign");

            entity.HasIndex(e => e.Status, "idx_status");

            entity.Property(e => e.Fccid)
                .ValueGeneratedNever()
                .HasColumnName("fccid");
            entity.Property(e => e.Callsign)
                .HasMaxLength(8)
                .HasColumnName("callsign");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasColumnName("status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}