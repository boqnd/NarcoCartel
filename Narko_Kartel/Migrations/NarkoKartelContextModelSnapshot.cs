﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLapp.Data;

namespace SQLapp.Migrations
{
    [DbContext(typeof(NarkoKartelContext))]
    partial class NarkoKartelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview3.19153.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SQLapp.Data.Model.Buyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DealerId");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("DealerId");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("SQLapp.Data.Model.Dealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityFrom")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<double>("Money_Brought_This_Month");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Dealers");
                });

            modelBuilder.Entity("SQLapp.Data.Model.Drug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Acquire_Price");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Quantity");

                    b.Property<double>("Sell_Price");

                    b.HasKey("Id");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("SQLapp.Data.Model.Money", b =>
                {
                    b.Property<string>("MoneyKey")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Money_Amount");

                    b.HasKey("MoneyKey");

                    b.ToTable("Money");
                });

            modelBuilder.Entity("SQLapp.Data.Model.Buyer", b =>
                {
                    b.HasOne("SQLapp.Data.Model.Dealer", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
