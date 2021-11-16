﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SofthouseTask.Data.Context;

namespace SofthouseTask.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SofthouseTask.Data.Models.JobApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("CV")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobApplication");
                });

            modelBuilder.Entity("SofthouseTask.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 187, 212, 84, 113, 244, 190, 65, 157, 255, 211, 56, 64, 193, 156, 233, 245, 152, 94, 71, 212, 156, 64, 12, 204, 61, 2, 229, 175, 22, 138, 241, 204, 179, 159, 173, 30, 32, 201, 108, 92, 189, 81, 185, 112, 24, 110, 230, 9, 7, 238, 14, 183, 112, 122, 93, 14, 172, 30, 185, 216, 202, 214, 216, 51 },
                            PasswordSalt = new byte[] { 56, 158, 24, 74, 176, 70, 165, 98, 45, 129, 133, 121, 57, 172, 216, 47, 184, 186, 221, 126, 158, 107, 10, 2, 142, 123, 111, 58, 234, 99, 19, 234, 128, 102, 41, 143, 132, 188, 5, 152, 243, 226, 18, 147, 172, 154, 175, 46, 59, 9, 145, 149, 9, 76, 71, 19, 230, 116, 145, 93, 195, 201, 60, 219, 30, 151, 59, 136, 190, 35, 132, 28, 191, 149, 200, 104, 233, 15, 4, 10, 195, 251, 226, 169, 178, 72, 252, 98, 235, 106, 82, 150, 32, 246, 210, 46, 203, 190, 41, 88, 65, 34, 73, 71, 0, 27, 176, 79, 205, 101, 217, 71, 74, 245, 220, 91, 31, 144, 3, 195, 238, 75, 84, 113, 118, 242, 10, 51 },
                            UserName = "HrAdmin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
