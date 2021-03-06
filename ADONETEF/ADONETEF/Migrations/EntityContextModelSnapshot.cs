﻿// <auto-generated />
using ADONETEF.MyMigration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ADONETEF.Migrations
{
    [DbContext(typeof(EntityContext))]
    partial class EntityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ADONETEF.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("OrderLoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Orderss");
                });

            modelBuilder.Entity("ADONETEF.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Productss");
                });

            modelBuilder.Entity("ADONETEF.Model.Order", b =>
                {
                    b.HasOne("ADONETEF.Model.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ADONETEF.Model.Product", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
