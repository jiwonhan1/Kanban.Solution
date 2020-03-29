﻿// <auto-generated />
using System;
using Kanban.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kanban.Migrations
{
    [DbContext(typeof(KanbanContext))]
    [Migration("20200329043214_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Kanban.Models.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactInfo");

                    b.Property<bool>("CurrentStatus");

                    b.Property<string>("Name");

                    b.Property<string>("Position");

                    b.Property<DateTime>("RegisteredDate");

                    b.HasKey("ManagerId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("Kanban.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ActiveStatus");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DueDate");

                    b.Property<DateTime>("KickOffDate");

                    b.Property<string>("ProjectName");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Kanban.Models.ProjectManager", b =>
                {
                    b.Property<int>("ProjectManagerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ManagerId");

                    b.Property<int>("ProjectId");

                    b.HasKey("ProjectManagerId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectManagers");
                });

            modelBuilder.Entity("Kanban.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StatusName");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = 1,
                            StatusName = "To-Do"
                        },
                        new
                        {
                            StatusId = 2,
                            StatusName = "In Progress"
                        },
                        new
                        {
                            StatusId = 3,
                            StatusName = "Testing"
                        },
                        new
                        {
                            StatusId = 4,
                            StatusName = "Done"
                        });
                });

            modelBuilder.Entity("Kanban.Models.ToDoList", b =>
                {
                    b.Property<int>("ToDoListId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckCompletion");

                    b.Property<string>("Content");

                    b.Property<string>("Name");

                    b.Property<int>("ProjectId");

                    b.Property<int>("StatusId");

                    b.Property<int>("priority");

                    b.HasKey("ToDoListId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("StatusId");

                    b.ToTable("ToDoLists");
                });

            modelBuilder.Entity("Kanban.Models.ProjectManager", b =>
                {
                    b.HasOne("Kanban.Models.Manager", "Manager")
                        .WithMany("Projects")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kanban.Models.Project", "Project")
                        .WithMany("Managers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kanban.Models.ToDoList", b =>
                {
                    b.HasOne("Kanban.Models.Project", "Project")
                        .WithMany("ToDoLists")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kanban.Models.Status", "Status")
                        .WithMany("ToDoLists")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
