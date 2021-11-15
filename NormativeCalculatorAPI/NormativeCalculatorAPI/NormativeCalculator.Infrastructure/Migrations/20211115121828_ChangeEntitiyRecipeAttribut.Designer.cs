﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NormativeCalculator.Infrastructure.EF;

namespace NormativeCalculator.Infrastructure.Migrations
{
    [DbContext(typeof(NormativeCalculatorDBContext))]
    [Migration("20211115121828_ChangeEntitiyRecipeAttribut")]
    partial class ChangeEntitiyRecipeAttribut
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MeasureUnit_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MeasureUnit_Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MeasureUnit_Id = 1,
                            Name = "Oil",
                            UnitPrice = 2m,
                            UnitQuantity = 1m
                        },
                        new
                        {
                            Id = 2,
                            MeasureUnit_Id = 1,
                            Name = "Water",
                            UnitPrice = 1m,
                            UnitQuantity = 1m
                        },
                        new
                        {
                            Id = 3,
                            MeasureUnit_Id = 2,
                            Name = "Sugar",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        },
                        new
                        {
                            Id = 4,
                            MeasureUnit_Id = 2,
                            Name = "Flour",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        },
                        new
                        {
                            Id = 5,
                            MeasureUnit_Id = 3,
                            Name = "Chocolate",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        },
                        new
                        {
                            Id = 6,
                            MeasureUnit_Id = 2,
                            Name = "Rice",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        },
                        new
                        {
                            Id = 7,
                            MeasureUnit_Id = 3,
                            Name = "Spaghetti",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        },
                        new
                        {
                            Id = 8,
                            MeasureUnit_Id = 2,
                            Name = "Chicken",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        },
                        new
                        {
                            Id = 9,
                            MeasureUnit_Id = 2,
                            Name = "Avocado",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        },
                        new
                        {
                            Id = 10,
                            MeasureUnit_Id = 3,
                            Name = "Salt",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        },
                        new
                        {
                            Id = 11,
                            MeasureUnit_Id = 5,
                            Name = "Banana",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        },
                        new
                        {
                            Id = 12,
                            MeasureUnit_Id = 5,
                            Name = "Apple",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        },
                        new
                        {
                            Id = 13,
                            MeasureUnit_Id = 4,
                            Name = "Mayonnaise",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        },
                        new
                        {
                            Id = 14,
                            MeasureUnit_Id = 5,
                            Name = "Bread",
                            UnitPrice = 2m,
                            UnitQuantity = 4m
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.MeasureUnits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MeasureUnit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MeasureUnits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MeasureUnit = "L"
                        },
                        new
                        {
                            Id = 2,
                            MeasureUnit = "kg"
                        },
                        new
                        {
                            Id = 3,
                            MeasureUnit = "gr"
                        },
                        new
                        {
                            Id = 4,
                            MeasureUnit = "ml"
                        },
                        new
                        {
                            Id = 5,
                            MeasureUnit = "kom"
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.RecipeCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RecipeCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Breakfast",
                            Created = new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Lunch",
                            Created = new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Dinner",
                            Created = new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Snacks",
                            Created = new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Salads",
                            Created = new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Rice",
                            Created = new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Pasta",
                            Created = new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Chicken",
                            Created = new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CategoryName = "Vegetarian",
                            Created = new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CategoryName = "Meat",
                            Created = new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            CategoryName = "Seafood",
                            Created = new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            CategoryName = "Desserts",
                            Created = new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            CategoryName = "Drinks",
                            Created = new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            CategoryName = "Burgers",
                            Created = new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Recipes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecipeCategory_Id")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeCategory_Id");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Recipes_Ingredients", b =>
                {
                    b.Property<int>("Ingredient_Id")
                        .HasColumnType("int");

                    b.Property<int>("Recipe_Id")
                        .HasColumnType("int");

                    b.Property<int>("MeasureUnit_Id")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Ingredient_Id", "Recipe_Id");

                    b.HasIndex("MeasureUnit_Id");

                    b.HasIndex("Recipe_Id");

                    b.ToTable("Recipes_Ingredients");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NormativeCalculator.Database.Ingredients", b =>
                {
                    b.HasOne("NormativeCalculator.Database.MeasureUnits", "MeasureUnit")
                        .WithMany()
                        .HasForeignKey("MeasureUnit_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeasureUnit");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Recipes", b =>
                {
                    b.HasOne("NormativeCalculator.Database.RecipeCategories", "RecipeCategory")
                        .WithMany()
                        .HasForeignKey("RecipeCategory_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("RecipeCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Recipes_Ingredients", b =>
                {
                    b.HasOne("NormativeCalculator.Database.Ingredients", "Ingredient")
                        .WithMany("Recipes_Ingredients")
                        .HasForeignKey("Ingredient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NormativeCalculator.Database.MeasureUnits", "MeasureUnit")
                        .WithMany()
                        .HasForeignKey("MeasureUnit_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NormativeCalculator.Database.Recipes", "Recipe")
                        .WithMany("Recipes_Ingredients")
                        .HasForeignKey("Recipe_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("MeasureUnit");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Ingredients", b =>
                {
                    b.Navigation("Recipes_Ingredients");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Recipes", b =>
                {
                    b.Navigation("Recipes_Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
