﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Music.Model;
using System;

namespace Music.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180629192408_addUserConnectionsToDB")]
    partial class addUserConnectionsToDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Music.Model.Music", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlbumName");

                    b.Property<string>("ArtistName");

                    b.Property<int>("Rating");

                    b.HasKey("ID");

                    b.ToTable("MusicItems");
                });
#pragma warning restore 612, 618
        }
    }
}
