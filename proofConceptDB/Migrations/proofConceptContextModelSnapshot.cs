﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proofConceptDB.Context;

#nullable disable

namespace proofConceptDB.Migrations
{
    [DbContext(typeof(proofConceptContext))]
    partial class proofConceptContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("proofConceptDB.DBEntities.Wand", b =>
                {
                    b.Property<int>("wandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("wandId"), 1L, 1);

                    b.Property<string>("core")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("flexibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("length")
                        .HasColumnType("int");

                    b.Property<float>("size")
                        .HasColumnType("real");

                    b.Property<string>("wood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("wandId");

                    b.ToTable("wands");
                });
#pragma warning restore 612, 618
        }
    }
}