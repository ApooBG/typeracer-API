// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(TyperacerContext))]
    partial class TyperacerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DAL.Models.Game", b =>
                {
                    b.Property<int>("GameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("User1ID")
                        .HasColumnType("int");

                    b.Property<int>("User2ID")
                        .HasColumnType("int");

                    b.HasKey("GameID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("DAL.Models.MainPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("image")
                        .HasColumnType("int");

                    b.Property<int>("wpm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MainPage");
                });

            modelBuilder.Entity("DAL.Models.Ranked", b =>
                {
                    b.Property<bool>("IsSearching")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Rank")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.ToTable("Rankeds");
                });

            modelBuilder.Entity("DAL.Models.Round", b =>
                {
                    b.Property<int>("RoundID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Accuracy1")
                        .HasColumnType("int");

                    b.Property<int?>("Accuracy2")
                        .HasColumnType("int");

                    b.Property<int>("GameID")
                        .HasColumnType("int");

                    b.Property<int?>("TotalScore1")
                        .HasColumnType("int");

                    b.Property<int?>("TotalScore2")
                        .HasColumnType("int");

                    b.Property<int?>("WPM1")
                        .HasColumnType("int");

                    b.Property<int?>("WPM2")
                        .HasColumnType("int");

                    b.Property<int?>("WinnerID")
                        .HasColumnType("int");

                    b.HasKey("RoundID");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Age")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("joined")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
