﻿// <auto-generated />
using System;
using Lib.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lib.Data.Migrations
{
    [DbContext(typeof(YdmApiDbContext))]
    partial class YdmApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Lib.Data.Entity.Category", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("Lib.Data.Entity.Customer", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<byte[]>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<byte[]>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("Lib.Data.Entity.Order", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte[]>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("CustomerId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte[]>("ProductId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<byte[]>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("order");
                });

            modelBuilder.Entity("Lib.Data.Entity.Product", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("CategoryId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<byte[]>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("product");
                });

            modelBuilder.Entity("Lib.Data.Entity.Order", b =>
                {
                    b.HasOne("Lib.Data.Entity.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.Data.Entity.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lib.Data.Entity.Product", b =>
                {
                    b.HasOne("Lib.Data.Entity.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
