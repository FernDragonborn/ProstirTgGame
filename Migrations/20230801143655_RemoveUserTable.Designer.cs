﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProstirTgBot.Data;

#nullable disable

namespace ProstirTgBot.Migrations
{
    [DbContext(typeof(ProstirTgBotContext))]
    [Migration("20230801143655_RemoveUserTable")]
    partial class RemoveUserTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProstirTgBot.Models.InGameEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivitiesFound")
                        .HasColumnType("int");

                    b.Property<int>("Apartment")
                        .HasColumnType("int");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InGameEvents");
                });

            modelBuilder.Entity("ProstirTgBot.Models.InGameEventChoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChoiceDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChoiceName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Energy")
                        .HasColumnType("int");

                    b.Property<int>("Happiness")
                        .HasColumnType("int");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<int?>("InGameEventId")
                        .HasColumnType("int");

                    b.Property<int>("Money")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InGameEventId");

                    b.ToTable("InGameEventChoice");
                });

            modelBuilder.Entity("ProstirTgBot.Models.InGameEventChoice", b =>
                {
                    b.HasOne("ProstirTgBot.Models.InGameEvent", null)
                        .WithMany("inGameEventChoices")
                        .HasForeignKey("InGameEventId");
                });

            modelBuilder.Entity("ProstirTgBot.Models.InGameEvent", b =>
                {
                    b.Navigation("inGameEventChoices");
                });
#pragma warning restore 612, 618
        }
    }
}
