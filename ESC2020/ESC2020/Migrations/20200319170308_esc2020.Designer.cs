﻿// <auto-generated />
using System;
using ESC2020.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ESC2020.Migrations
{
    [DbContext(typeof(ElectionContext))]
    [Migration("20200319170308_esc2020")]
    partial class esc2020
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ESC2020.Model.Election", b =>
                {
                    b.Property<int>("ElectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Mission")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PhaseId")
                        .HasColumnType("integer");

                    b.Property<string>("Responsability")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("integer");

                    b.HasKey("ElectionId");

                    b.HasIndex("PhaseId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("Election");
                });

            modelBuilder.Entity("ESC2020.Model.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateMessage")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ElectionId")
                        .HasColumnType("integer");

                    b.Property<string>("Sentence")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("MessageId");

                    b.HasIndex("ElectionId");

                    b.HasIndex("UserId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("ESC2020.Model.Notification", b =>
                {
                    b.Property<int>("NotifId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateNotification")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ElectionId")
                        .HasColumnType("integer");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("NotifId");

                    b.HasIndex("ElectionId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("ESC2020.Model.Opinion", b =>
                {
                    b.Property<int>("OpinionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int?>("AuthorIdConcernedId")
                        .HasColumnType("integer");

                    b.Property<int>("ConcernedId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateOpinion")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ElectionId")
                        .HasColumnType("integer");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.HasKey("OpinionId");

                    b.HasIndex("AuthorIdConcernedId");

                    b.HasIndex("ElectionId");

                    b.HasIndex("TypeId");

                    b.ToTable("Opinion");
                });

            modelBuilder.Entity("ESC2020.Model.Participant", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("ElectionId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "ElectionId");

                    b.HasIndex("ElectionId");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("ESC2020.Model.Phase", b =>
                {
                    b.Property<int>("PhaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("PhaseName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PhaseId");

                    b.ToTable("Phase");
                });

            modelBuilder.Entity("ESC2020.Model.TypeOpinion", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("OpinionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TypeId");

                    b.ToTable("TypeOpinion");
                });

            modelBuilder.Entity("ESC2020.Model.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ESC2020.Model.Election", b =>
                {
                    b.HasOne("ESC2020.Model.Phase", null)
                        .WithMany("Election")
                        .HasForeignKey("PhaseId");

                    b.HasOne("ESC2020.Model.Users", null)
                        .WithMany("Election")
                        .HasForeignKey("UsersUserId");
                });

            modelBuilder.Entity("ESC2020.Model.Message", b =>
                {
                    b.HasOne("ESC2020.Model.Election", "Election")
                        .WithMany("Message")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESC2020.Model.Users", "User")
                        .WithMany("Message")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ESC2020.Model.Notification", b =>
                {
                    b.HasOne("ESC2020.Model.Election", "Election")
                        .WithMany("Notification")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ESC2020.Model.Opinion", b =>
                {
                    b.HasOne("ESC2020.Model.Users", "User")
                        .WithMany("Opinion")
                        .HasForeignKey("AuthorIdConcernedId");

                    b.HasOne("ESC2020.Model.Election", "Election")
                        .WithMany("Opinion")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESC2020.Model.TypeOpinion", "TypeOpinion")
                        .WithMany("Opinion")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ESC2020.Model.Participant", b =>
                {
                    b.HasOne("ESC2020.Model.Election", "Elections")
                        .WithMany("Participant")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESC2020.Model.Users", "User")
                        .WithMany("Participants")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
