﻿// <auto-generated />
using System;
using Accounts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Accounts.Migrations
{
    [DbContext(typeof(AccountContext))]
    [Migration("20180610112323_Added Account Model")]
    partial class AddedAccountModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799");

            modelBuilder.Entity("Accounts.Models.Account", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
