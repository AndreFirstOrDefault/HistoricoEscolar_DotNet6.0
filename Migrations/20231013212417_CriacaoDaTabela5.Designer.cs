﻿// <auto-generated />
using System;
using HistoricoEscolar.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HistoricoEscolar.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231013212417_CriacaoDaTabela5")]
    partial class CriacaoDaTabela5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HistoricoEscolar.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlunoId"), 1L, 1);

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Polo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AlunoId");

                    b.HasIndex("CursoId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("HistoricoEscolar.Models.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CursoId"), 1L, 1);

                    b.Property<string>("NomeDoCurso")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("HistoricoEscolar.Models.Disciplina", b =>
                {
                    b.Property<int>("DisciplinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisciplinaId"), 1L, 1);

                    b.Property<string>("NomeDaDisciplina")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DisciplinaId");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("HistoricoEscolar.Models.Historico", b =>
                {
                    b.Property<int>("HistoricoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoricoId"), 1L, 1);

                    b.Property<int?>("AlunoId")
                        .HasColumnType("int");

                    b.Property<decimal>("AvaliacaoPresencial")
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("AvalicaoOnline")
                        .HasColumnType("decimal(2,2)");

                    b.Property<int?>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Media")
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("PIM")
                        .HasColumnType("decimal(2,2)");

                    b.Property<string>("Periodo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("HistoricoId");

                    b.HasIndex("AlunoId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("Histórico");
                });

            modelBuilder.Entity("HistoricoEscolar.Models.Aluno", b =>
                {
                    b.HasOne("HistoricoEscolar.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("HistoricoEscolar.Models.Historico", b =>
                {
                    b.HasOne("HistoricoEscolar.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId");

                    b.HasOne("HistoricoEscolar.Models.Disciplina", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaId");

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });
#pragma warning restore 612, 618
        }
    }
}
