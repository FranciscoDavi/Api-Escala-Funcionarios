﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Api.Data;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(EscalaDBContext))]
    [Migration("20250226222715_AdicionadoTarefasERelacionamentos")]
    partial class AdicionadoTarefasERelacionamentos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("api.Models.FuncionarioTurno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FuncionarioID")
                        .HasColumnType("int");

                    b.Property<int>("TurnoID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioID");

                    b.HasIndex("TurnoID");

                    b.ToTable("FuncionarioTurnos");
                });

            modelBuilder.Entity("api.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tarefa");
                });

            modelBuilder.Entity("api.Models.TarefaFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FuncionarioID")
                        .HasColumnType("int");

                    b.Property<int>("TarefaID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioID");

                    b.HasIndex("TarefaID");

                    b.ToTable("TarefaFuncionario");
                });

            modelBuilder.Entity("api.Models.Turno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora_Inicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora_Termino")
                        .HasColumnType("datetime2");

                    b.Property<string>("Periodo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Turnos");
                });

            modelBuilder.Entity("api.Models.FuncionarioTurno", b =>
                {
                    b.HasOne("api.Models.Funcionario", "Funcionario")
                        .WithMany("FuncionariosTurnos")
                        .HasForeignKey("FuncionarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.Turno", "Turno")
                        .WithMany("FuncionariosTurnos")
                        .HasForeignKey("TurnoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Turno");
                });

            modelBuilder.Entity("api.Models.TarefaFuncionario", b =>
                {
                    b.HasOne("api.Models.Funcionario", "Funcionario")
                        .WithMany("TarefasFuncionarios")
                        .HasForeignKey("FuncionarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.Tarefa", "Tarefa")
                        .WithMany("TarefasFuncionarios")
                        .HasForeignKey("TarefaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Tarefa");
                });

            modelBuilder.Entity("api.Models.Funcionario", b =>
                {
                    b.Navigation("FuncionariosTurnos");

                    b.Navigation("TarefasFuncionarios");
                });

            modelBuilder.Entity("api.Models.Tarefa", b =>
                {
                    b.Navigation("TarefasFuncionarios");
                });

            modelBuilder.Entity("api.Models.Turno", b =>
                {
                    b.Navigation("FuncionariosTurnos");
                });
#pragma warning restore 612, 618
        }
    }
}
