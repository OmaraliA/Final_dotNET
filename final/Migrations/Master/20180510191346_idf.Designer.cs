﻿// <auto-generated />
using final.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace final.Migrations.Master
{
    [DbContext(typeof(MasterContext))]
    [Migration("20180510191346_idf")]
    partial class idf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("final.Master", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustDocument");

                    b.Property<string>("CustName");

                    b.Property<string>("CustSurname");

                    b.Property<DateTime>("DateOfSale");

                    b.HasKey("Id");

                    b.ToTable("Masters");
                });
#pragma warning restore 612, 618
        }
    }
}
