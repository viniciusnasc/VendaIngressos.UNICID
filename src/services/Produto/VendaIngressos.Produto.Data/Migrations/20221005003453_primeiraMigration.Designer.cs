﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendaIngressos.Produto.Data;

#nullable disable

namespace VendaIngressos.Produto.Data.Migrations
{
    [DbContext(typeof(ProdutoContexto))]
    [Migration("20221005003453_primeiraMigration")]
    partial class primeiraMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Atracao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Descricao")
                        .HasColumnType("VARCHAR(500)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("OrganizadorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)");

                    b.Property<int>("QuantidadeIngresso")
                        .HasColumnType("INT");

                    b.Property<Guid>("ShowHouseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TipoEvento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizadorId");

                    b.HasIndex("ShowHouseId");

                    b.ToTable("Atracoes", (string)null);
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cep")
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Complemento")
                        .HasColumnType("Varchar(100)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MunicipioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .HasColumnType("Varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Municipio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeMunicipio")
                        .HasColumnType("Varchar(100)");

                    b.Property<Guid>("UfId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UfId");

                    b.ToTable("Municipio");
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Organizador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)");

                    b.Property<string>("Telefone")
                        .HasColumnType("CHAR(11)");

                    b.HasKey("Id");

                    b.ToTable("Organizadores", (string)null);
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.ShowHouse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Telefone")
                        .HasColumnType("Varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("ShowHouse");
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Uf", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Sigla")
                        .HasColumnType("Varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Uf");

                    b.HasData(
                        new
                        {
                            Id = new Guid("77df935a-ca53-4ffd-94ae-c197e016ccf0"),
                            CreateAt = new DateTime(2022, 10, 5, 0, 34, 53, 439, DateTimeKind.Utc).AddTicks(7099),
                            Nome = "Acre",
                            Sigla = "AC"
                        },
                        new
                        {
                            Id = new Guid("8f7ae6df-d6a5-4d86-8994-e64002ee557e"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7110),
                            Nome = "Alagoas",
                            Sigla = "AL"
                        },
                        new
                        {
                            Id = new Guid("489e8c02-00cc-4113-8dab-8e44ead66543"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7124),
                            Nome = "Amapa",
                            Sigla = "AP"
                        },
                        new
                        {
                            Id = new Guid("2b3cb7d6-f792-4ae6-b068-38da911997d8"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7127),
                            Nome = "Amazonas",
                            Sigla = "AM"
                        },
                        new
                        {
                            Id = new Guid("3a8ca4e0-eb66-452c-b4d5-dd4b428f3cbf"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7130),
                            Nome = "Bahia",
                            Sigla = "BA"
                        },
                        new
                        {
                            Id = new Guid("38cdbdab-bc0b-4f2e-b561-500a1708d8da"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7132),
                            Nome = "Ceara",
                            Sigla = "CE"
                        },
                        new
                        {
                            Id = new Guid("20792100-80af-49a8-8195-f7c36441c38d"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7135),
                            Nome = "Espirito Santo",
                            Sigla = "ES"
                        },
                        new
                        {
                            Id = new Guid("8c797ec8-ea24-4bc5-9288-56a6cb14a8ef"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7138),
                            Nome = "Goias",
                            Sigla = "GO"
                        },
                        new
                        {
                            Id = new Guid("7451a52c-8460-4f6a-bca6-7573b9a44759"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7141),
                            Nome = "Maranhao",
                            Sigla = "MA"
                        },
                        new
                        {
                            Id = new Guid("786e47a5-f326-40bc-afb5-0af531e7af9f"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7143),
                            Nome = "Mato Grosso",
                            Sigla = "MT"
                        },
                        new
                        {
                            Id = new Guid("c4dc2412-b190-411a-8352-0a857b7e327b"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7146),
                            Nome = "Mato Grosso do Sul",
                            Sigla = "MS"
                        },
                        new
                        {
                            Id = new Guid("3b72bc3f-4613-4313-963c-9621db443e32"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7149),
                            Nome = "Minas Gerais",
                            Sigla = "MG"
                        },
                        new
                        {
                            Id = new Guid("06759cc3-cf92-49fe-9d98-a8eacb5ee621"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7152),
                            Nome = "Para",
                            Sigla = "PA"
                        },
                        new
                        {
                            Id = new Guid("d4fdba6b-ee4c-4c06-b8d7-7dcbbc0d02fa"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7155),
                            Nome = "Paraiba",
                            Sigla = "PB"
                        },
                        new
                        {
                            Id = new Guid("ef7e5a58-45a2-4b80-8e13-fdeefb2f5a5e"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7178),
                            Nome = "Parana",
                            Sigla = "PR"
                        },
                        new
                        {
                            Id = new Guid("451ecb2b-0ba5-48c7-84ff-32772634c258"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7183),
                            Nome = "Pernambuco",
                            Sigla = "PE"
                        },
                        new
                        {
                            Id = new Guid("275002db-aa62-444e-a179-b801583c3568"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7185),
                            Nome = "Piaui",
                            Sigla = "PI"
                        },
                        new
                        {
                            Id = new Guid("3b0458c6-5eff-4342-bd53-4591d7c006de"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7188),
                            Nome = "Rio de Janeiro",
                            Sigla = "RJ"
                        },
                        new
                        {
                            Id = new Guid("dca93b97-5ef7-44ee-bfb4-5f63b0c72598"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7191),
                            Nome = "Rio Grande do Norte",
                            Sigla = "RN"
                        },
                        new
                        {
                            Id = new Guid("6b57ce63-eb3a-4c73-8b59-8098e6862d48"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7193),
                            Nome = "Rio Grande do Sul",
                            Sigla = "RS"
                        },
                        new
                        {
                            Id = new Guid("12405ad1-e3e5-43fd-9bfe-0c6fa4816105"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7308),
                            Nome = "Rondonia",
                            Sigla = "RO"
                        },
                        new
                        {
                            Id = new Guid("a850fb53-9f5b-449e-b691-d084f8b5a402"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7315),
                            Nome = "Roraima",
                            Sigla = "RR"
                        },
                        new
                        {
                            Id = new Guid("dbb01ebc-4776-4f72-b630-7b249d81c440"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7320),
                            Nome = "Santa Catarina",
                            Sigla = "SC"
                        },
                        new
                        {
                            Id = new Guid("5e684315-735e-4c8e-a508-8df50649dc1d"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7323),
                            Nome = "Sao Paulo",
                            Sigla = "SP"
                        },
                        new
                        {
                            Id = new Guid("6d2e386b-a450-4976-83ce-ed107120c9fb"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7326),
                            Nome = "Sergipe",
                            Sigla = "SE"
                        },
                        new
                        {
                            Id = new Guid("7fdaaa4c-13ed-49d4-b1aa-ceaae53254b6"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7329),
                            Nome = "Tocantins",
                            Sigla = "TO"
                        },
                        new
                        {
                            Id = new Guid("141a0daa-47e8-49fe-8dea-0ee97e4db538"),
                            CreateAt = new DateTime(2022, 10, 4, 21, 34, 53, 439, DateTimeKind.Local).AddTicks(7332),
                            Nome = "Distrito Federal",
                            Sigla = "DF"
                        });
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Atracao", b =>
                {
                    b.HasOne("VendaIngressos.Produto.Domain.Entities.Organizador", "Organizador")
                        .WithMany("Atracoes")
                        .HasForeignKey("OrganizadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VendaIngressos.Produto.Domain.Entities.ShowHouse", "ShowHouse")
                        .WithMany()
                        .HasForeignKey("ShowHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organizador");

                    b.Navigation("ShowHouse");
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Endereco", b =>
                {
                    b.HasOne("VendaIngressos.Produto.Domain.Entities.Municipio", "Municipio")
                        .WithMany("Enderecos")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Municipio", b =>
                {
                    b.HasOne("VendaIngressos.Produto.Domain.Entities.Uf", "Uf")
                        .WithMany("Municipios")
                        .HasForeignKey("UfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uf");
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.ShowHouse", b =>
                {
                    b.HasOne("VendaIngressos.Produto.Domain.Entities.Endereco", "Endereco")
                        .WithMany("MyProperty")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Endereco", b =>
                {
                    b.Navigation("MyProperty");
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Municipio", b =>
                {
                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Organizador", b =>
                {
                    b.Navigation("Atracoes");
                });

            modelBuilder.Entity("VendaIngressos.Produto.Domain.Entities.Uf", b =>
                {
                    b.Navigation("Municipios");
                });
#pragma warning restore 612, 618
        }
    }
}
