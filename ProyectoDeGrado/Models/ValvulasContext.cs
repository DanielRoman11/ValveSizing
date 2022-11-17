using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoDeGrado.Models;

public partial class ValvulasContext : DbContext
{
    public ValvulasContext()
    {
    }

    public ValvulasContext(DbContextOptions<ValvulasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Valvula> Valvulas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server='DESKTOP-LCIMTLI'; Database=Valvulas; Trusted_Connection=True; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Valvula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VALVULA");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CREACION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.VSalida).HasColumnName("V_Salida");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
