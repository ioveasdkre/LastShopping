﻿// <auto-generated />
using System;
using LastShopping.Database.DbContextModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LastShopping.Database.Migrations.UserAppDb
{
    [DbContext(typeof(UserAppDbContext))]
    partial class UserAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerLoginLog", b =>
                {
                    b.Property<int>("ManagerLoginLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerLoginLogId"), 1L, 1);

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerMainManagerId")
                        .HasColumnType("int");

                    b.HasKey("ManagerLoginLogId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("ManagerMainManagerId");

                    b.ToTable("ManagerLoginLogs");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerMain", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerId"), 1L, 1);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("Date");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<int>("ManagerRoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ManagerId");

                    b.HasIndex("Account");

                    b.HasIndex("ManagerRoleId");

                    b.ToTable("ManagerMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRefreshTokenLog", b =>
                {
                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RefreshToken", "ManagerId");

                    b.HasIndex("ManagerId");

                    b.ToTable("ManagerRefreshTokenLogs");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRole", b =>
                {
                    b.Property<int>("ManagerRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerRoleId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ManagerRoleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ManagerRoleId");

                    b.ToTable("ManagerRole");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRoleAuth", b =>
                {
                    b.Property<int>("RouterId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerRoleId")
                        .HasColumnType("int");

                    b.Property<string>("CreateAuth")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteAuth")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)");

                    b.Property<string>("ExportAuth")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)");

                    b.Property<string>("ModifyAuth")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ViewAuth")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)");

                    b.HasKey("RouterId", "ManagerRoleId");

                    b.HasIndex("ManagerRoleId");

                    b.HasIndex("RouterId");

                    b.ToTable("ManagerRoleAuths");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.Router", b =>
                {
                    b.Property<int>("RouterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouterId"), 1L, 1);

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("RouterName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("RouterId");

                    b.ToTable("Router");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserLoginLog", b =>
                {
                    b.Property<int>("LoginLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginLogId"), 1L, 1);

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserMainUserId")
                        .HasColumnType("int");

                    b.HasKey("LoginLogId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserMainUserId");

                    b.ToTable("UserLoginLogs");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserMain", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("Date");

                    b.Property<bool>("Cable")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Privacy")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserId");

                    b.HasIndex("Account");

                    b.ToTable("UserMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserRefreshTokenLog", b =>
                {
                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RefreshToken", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRefreshTokenLogs");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerLoginLog", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.ManagerMain", "ManagerMain")
                        .WithMany("ManagerLoginLogs")
                        .HasForeignKey("ManagerMainManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerMain", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.ManagerRole", "ManagerRole")
                        .WithMany("ManagerMains")
                        .HasForeignKey("ManagerRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerRole");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRefreshTokenLog", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.ManagerMain", "ManagerMain")
                        .WithMany("ManagerRefreshTokenLogs")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRoleAuth", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.ManagerRole", "ManagerRole")
                        .WithMany("ManagerRoleAuths")
                        .HasForeignKey("ManagerRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LastShopping.Database.UserAppModels.Router", "Router")
                        .WithMany("ManagerRoleAuths")
                        .HasForeignKey("RouterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerRole");

                    b.Navigation("Router");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserLoginLog", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.UserMain", "UserMain")
                        .WithMany("UserLoginLogs")
                        .HasForeignKey("UserMainUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserRefreshTokenLog", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.UserMain", "UserMain")
                        .WithMany("UserRefreshTokenLogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerMain", b =>
                {
                    b.Navigation("ManagerLoginLogs");

                    b.Navigation("ManagerRefreshTokenLogs");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRole", b =>
                {
                    b.Navigation("ManagerMains");

                    b.Navigation("ManagerRoleAuths");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.Router", b =>
                {
                    b.Navigation("ManagerRoleAuths");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserMain", b =>
                {
                    b.Navigation("UserLoginLogs");

                    b.Navigation("UserRefreshTokenLogs");
                });
#pragma warning restore 612, 618
        }
    }
}