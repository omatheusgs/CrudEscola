﻿// <auto-generated />
using System;
using CrudEscola.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudEscola.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CrudEscola.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Aluno");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AlunoID")
                        .HasColumnType("int");

                    b.Property<int>("IdadeAluno")
                        .HasColumnType("int")
                        .HasColumnName("Idade_Aluno");

                    b.Property<string>("NomeAluno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome_Aluno");

                    b.Property<int?>("TurmaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlunoID");

                    b.HasIndex("TurmaId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("CrudEscola.Models.Escola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Escola");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeEscola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome_Escola");

                    b.HasKey("Id");

                    b.ToTable("Escola");
                });

            modelBuilder.Entity("CrudEscola.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Turma");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeTurma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome_Turma");

                    b.Property<string>("SalaTurma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Sala_Turma");

                    b.HasKey("Id");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("CrudEscola.Models.Aluno", b =>
                {
                    b.HasOne("CrudEscola.Models.Aluno", "AlunoDD")
                        .WithMany()
                        .HasForeignKey("AlunoID");

                    b.HasOne("CrudEscola.Models.Turma", null)
                        .WithMany("Alunos")
                        .HasForeignKey("TurmaId");

                    b.Navigation("AlunoDD");
                });

            modelBuilder.Entity("CrudEscola.Models.Turma", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
