﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RiskRegisterII.Data;

namespace RiskRegisterII.Migrations
{
    [DbContext(typeof(RiskRegisterDbContext))]
    [Migration("20181003092909_edited the complaint register model")]
    partial class editedthecomplaintregistermodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RiskRegister.Models.ActionTaken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("LastUpdated");

                    b.Property<int?>("RiskMonitorId");

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("RiskMonitorId");

                    b.ToTable("ActionTaken");
                });

            modelBuilder.Entity("RiskRegister.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("RiskRegister.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("RiskRegister.Models.RiskMonitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime?>("LastUpdated");

                    b.Property<string>("ReferenceId");

                    b.Property<int?>("RiskTypeId");

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("RiskTypeId");

                    b.ToTable("riskMonitors");
                });

            modelBuilder.Entity("RiskRegister.Models.RiskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.Property<string>("ViewId");

                    b.HasKey("Id");

                    b.ToTable("riskTypes");
                });

            modelBuilder.Entity("RiskRegisterII.Models.ComplaintRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactPerson");

                    b.Property<DateTime>("DateReceived");

                    b.Property<string>("Description");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("NameofClient");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("complaintRegisters");
                });

            modelBuilder.Entity("RiskRegisterII.Models.ErrorRegisterModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime?>("DateUpdated");

                    b.Property<int>("DepartmentId");

                    b.Property<int>("ErrorStatus");

                    b.Property<string>("ErrorType");

                    b.Property<string>("Narration");

                    b.Property<string>("Officer");

                    b.Property<string>("Remark");

                    b.Property<int>("RiskTypeId");

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RiskTypeId");

                    b.ToTable("errorRegisters");
                });

            modelBuilder.Entity("RiskRegister.Models.ActionTaken", b =>
                {
                    b.HasOne("RiskRegister.Models.RiskMonitor")
                        .WithMany("ActionsTaken")
                        .HasForeignKey("RiskMonitorId");
                });

            modelBuilder.Entity("RiskRegister.Models.RiskMonitor", b =>
                {
                    b.HasOne("RiskRegister.Models.RiskType", "RiskType")
                        .WithMany()
                        .HasForeignKey("RiskTypeId");
                });

            modelBuilder.Entity("RiskRegisterII.Models.ErrorRegisterModel", b =>
                {
                    b.HasOne("RiskRegister.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RiskRegister.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RiskRegister.Models.RiskType", "RiskType")
                        .WithMany()
                        .HasForeignKey("RiskTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
