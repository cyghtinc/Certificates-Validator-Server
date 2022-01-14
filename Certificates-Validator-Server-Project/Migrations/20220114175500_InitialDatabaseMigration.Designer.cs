﻿// <auto-generated />
using Certificates_Validator_Server_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Certificates_Validator_Server_Project.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220114175500_InitialDatabaseMigration")]
    partial class InitialDatabaseMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Certificates_Validator_Server_Project.Data.Models.FileSec", b =>
                {
                    b.Property<string>("sha256Hash")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("fileAuthenticodeMD5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fileAuthenticodeSHA1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fileAuthenticodeSHA256")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("fileINCore")
                        .HasColumnType("bit");

                    b.Property<string>("fileSignCompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fileSignSerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("fileSignatureCatalog")
                        .HasColumnType("bit");

                    b.Property<bool>("fileSigned")
                        .HasColumnType("bit");

                    b.Property<string>("filename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filepath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("md5Hash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sha1Hash")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sha256Hash");

                    b.ToTable("Files");
                });
#pragma warning restore 612, 618
        }
    }
}
