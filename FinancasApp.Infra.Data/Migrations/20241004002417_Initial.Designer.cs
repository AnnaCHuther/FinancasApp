﻿// <auto-generated />
using System;
using FinancasApp.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinancasApp.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241004002417_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinancasApp.Domain.Entities.Categoria", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOME");

                    b.Property<Guid?>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("USUARIO_ID");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_CATEGORIA", (string)null);
                });

            modelBuilder.Entity("FinancasApp.Domain.Entities.Conta", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid?>("CategoriaId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CATEGORIA_ID");

                    b.Property<DateTime?>("Data")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NOME");

                    b.Property<int?>("Tipo")
                        .HasColumnType("int");

                    b.Property<Guid?>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("USUARIO_ID");

                    b.Property<decimal?>("Valor")
                        .IsRequired()
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("VALOR");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_CONTA", (string)null);
                });

            modelBuilder.Entity("FinancasApp.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("NOME");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SENHA");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("TB_USUARIO", (string)null);
                });

            modelBuilder.Entity("FinancasApp.Domain.Entities.Categoria", b =>
                {
                    b.HasOne("FinancasApp.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Categorias")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("FinancasApp.Domain.Entities.Conta", b =>
                {
                    b.HasOne("FinancasApp.Domain.Entities.Categoria", "Categoria")
                        .WithMany("Contas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FinancasApp.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Contas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("FinancasApp.Domain.Entities.Categoria", b =>
                {
                    b.Navigation("Contas");
                });

            modelBuilder.Entity("FinancasApp.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Categorias");

                    b.Navigation("Contas");
                });
#pragma warning restore 612, 618
        }
    }
}
