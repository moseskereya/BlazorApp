﻿// <auto-generated />
using BlazorApp4.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorApp4.Server.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorApp4.Shared.Models.Developer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Experience")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Developers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "myemail@gmail.com",
                            Experience = 3m,
                            FirstName = "Moses",
                            LastName = "Lazaro"
                        },
                        new
                        {
                            Id = 2,
                            Email = "scott@gmail.com",
                            Experience = 40m,
                            FirstName = "Scott",
                            LastName = "Cate"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Dev@gmai.com",
                            Experience = 10m,
                            FirstName = "Dev",
                            LastName = "Edd"
                        },
                        new
                        {
                            Id = 4,
                            Email = "travesy@gmail.com",
                            Experience = 20m,
                            FirstName = "Brad",
                            LastName = "Travesy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
