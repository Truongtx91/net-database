﻿// <auto-generated />
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ReactApp.Data;

namespace ReactApp.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20190808032038_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ReactApp.Models.Story", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<long>("CreationTime");

                    b.Property<bool>("Draft");

                    b.Property<long>("LastEditTime");

                    b.Property<string>("OwnerId")
                        .IsRequired();

                    b.Property<long>("PublishTime");

                    b.Property<List<string>>("Tags");

                    b.Property<string>("Title")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Story");
                });

            modelBuilder.Entity("ReactApp.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ReactApp.Models.Story", b =>
                {
                    b.HasOne("ReactApp.Models.User", "Owner")
                        .WithMany("Stories")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}