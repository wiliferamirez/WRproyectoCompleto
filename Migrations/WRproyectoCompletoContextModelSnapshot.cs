﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WRproyectoCompleto.Data;

#nullable disable

namespace WRproyectoCompleto.Migrations
{
    [DbContext(typeof(WRproyectoCompletoContext))]
    partial class WRproyectoCompletoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WRproyectoCompleto.Models.WREstudiante", b =>
                {
                    b.Property<int>("WRestudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WRestudianteId"));

                    b.Property<string>("WRapellidoEstudiante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WRcedulaEstudiante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WRedad")
                        .HasColumnType("int");

                    b.Property<string>("WRnombreEstudiante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WRnombreRepresentanteEstudiante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WRestudianteId");

                    b.ToTable("WREstudiante");
                });
#pragma warning restore 612, 618
        }
    }
}
