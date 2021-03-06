﻿// <auto-generated />
using System;
using CrearOtroRegistro.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrearOtroRegistro.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210205051110_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CrearOtroRegistro.Entidades.Roll", b =>
                {
                    b.Property<int>("RollId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Roles")
                        .HasColumnType("TEXT");

                    b.HasKey("RollId");

                    b.ToTable("Rolles");
                });

            modelBuilder.Entity("CrearOtroRegistro.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescripcionRol")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RolId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CrearOtroRegistro.Entidades.Usuarios", b =>
                {
                    b.HasOne("CrearOtroRegistro.Entidades.Roll", "roll")
                        .WithMany()
                        .HasForeignKey("RolId");

                    b.Navigation("roll");
                });
#pragma warning restore 612, 618
        }
    }
}
