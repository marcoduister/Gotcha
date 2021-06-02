﻿// <auto-generated />
using System;
using Gotcha.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gotcha.Migrations
{
    [DbContext(typeof(Gotcha_DBcontext))]
    partial class Gotcha_DBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gotcha.Models.Contract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EliminatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Eliminations")
                        .HasColumnType("int");

                    b.Property<Guid>("Game_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Word_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Game_Id");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Gotcha.Models.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EindTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GameType_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Maker_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RandomWiner")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RuleSet_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("WordSet_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GameType_Id");

                    b.HasIndex("Maker_Id");

                    b.HasIndex("RuleSet_Id");

                    b.HasIndex("WordSet_Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Gotcha.Models.GameType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Maker_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Maker_Id");

                    b.ToTable("GameTypes");
                });

            modelBuilder.Entity("Gotcha.Models.Rule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Maker_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Maker_Id");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("Gotcha.Models.RuleLink", b =>
                {
                    b.Property<Guid>("RuleSet_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Rule_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RuleSet_Id", "Rule_Id");

                    b.HasIndex("Rule_Id");

                    b.ToTable("RuleLinks");
                });

            modelBuilder.Entity("Gotcha.Models.RuleSet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Maker_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Maker_Id");

                    b.ToTable("RuleSets");
                });

            modelBuilder.Entity("Gotcha.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Maker_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ProfileImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("UserActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("userId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Gotcha.Models.Word", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Maker_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Maker_Id");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("Gotcha.Models.WordLink", b =>
                {
                    b.Property<Guid>("WordSet_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Word_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("WordSet_Id", "Word_Id");

                    b.HasIndex("Word_Id");

                    b.ToTable("WordLinks");
                });

            modelBuilder.Entity("Gotcha.Models.WordSet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Maker_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Maker_Id");

                    b.ToTable("WordSets");
                });

            modelBuilder.Entity("Gotcha.Models.Contract", b =>
                {
                    b.HasOne("Gotcha.Models.Game", "Game")
                        .WithMany("Contracts")
                        .HasForeignKey("Game_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gotcha.Models.Game", b =>
                {
                    b.HasOne("Gotcha.Models.GameType", "GameType")
                        .WithMany("Games")
                        .HasForeignKey("GameType_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gotcha.Models.User", "User")
                        .WithMany("Games")
                        .HasForeignKey("Maker_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Gotcha.Models.RuleSet", "RuleSet")
                        .WithMany("Games")
                        .HasForeignKey("RuleSet_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gotcha.Models.WordSet", "WordSet")
                        .WithMany("Games")
                        .HasForeignKey("WordSet_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gotcha.Models.GameType", b =>
                {
                    b.HasOne("Gotcha.Models.User", "User")
                        .WithMany("GameTypes")
                        .HasForeignKey("Maker_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Gotcha.Models.Rule", b =>
                {
                    b.HasOne("Gotcha.Models.User", "User")
                        .WithMany("Rules")
                        .HasForeignKey("Maker_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Gotcha.Models.RuleLink", b =>
                {
                    b.HasOne("Gotcha.Models.RuleSet", "RuleSet")
                        .WithMany("RuleLinks")
                        .HasForeignKey("RuleSet_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gotcha.Models.Rule", "Rule")
                        .WithMany("RuleLinks")
                        .HasForeignKey("Rule_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gotcha.Models.RuleSet", b =>
                {
                    b.HasOne("Gotcha.Models.User", "User")
                        .WithMany("RuleSets")
                        .HasForeignKey("Maker_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Gotcha.Models.User", b =>
                {
                    b.HasOne("Gotcha.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("Gotcha.Models.Word", b =>
                {
                    b.HasOne("Gotcha.Models.User", "User")
                        .WithMany("Word")
                        .HasForeignKey("Maker_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Gotcha.Models.WordLink", b =>
                {
                    b.HasOne("Gotcha.Models.WordSet", "WordSet")
                        .WithMany("WordLinks")
                        .HasForeignKey("WordSet_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gotcha.Models.Word", "Word")
                        .WithMany("WordLinks")
                        .HasForeignKey("Word_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gotcha.Models.WordSet", b =>
                {
                    b.HasOne("Gotcha.Models.User", "User")
                        .WithMany("WordSets")
                        .HasForeignKey("Maker_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
