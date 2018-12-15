﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nobatgir.Data;

namespace _3Nobatgir.Data.Migrations.My
{
    [DbContext(typeof(MyContext))]
    [Migration("13970924071025_sourcetypeexpert1")]
    partial class sourcetypeexpert1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nobatgir.Model.AdminMenu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionName");

                    b.Property<string>("ControllerName");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("LevelID");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<int>("SiteKindID");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("SiteKindID");

                    b.ToTable("AdminMenus");
                });

            modelBuilder.Entity("Nobatgir.Model.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<int>("SiteID");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("SiteID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Nobatgir.Model.CategorySetting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("CategorySettings");
                });

            modelBuilder.Entity("Nobatgir.Model.DictionaryTerm", b =>
                {
                    b.Property<int>("ID");

                    b.Property<string>("Term");

                    b.HasKey("ID");

                    b.ToTable("DictionaryTerms");
                });

            modelBuilder.Entity("Nobatgir.Model.Expert", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Experts");
                });

            modelBuilder.Entity("Nobatgir.Model.ExpertField", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CssClass");

                    b.Property<string>("DefaultValue");

                    b.Property<int>("ExpertID");

                    b.Property<string>("FieldText");

                    b.Property<int>("FieldType");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<string>("Placeholder");

                    b.Property<int?>("SourceTypeID");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("ExpertID");

                    b.HasIndex("SourceTypeID");

                    b.ToTable("ExpertFields");
                });

            modelBuilder.Entity("Nobatgir.Model.ExpertSetting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExpertID");

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("ExpertID");

                    b.ToTable("ExpertSettings");
                });

            modelBuilder.Entity("Nobatgir.Model.ExpertTimeTemplate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActiveDayCount");

                    b.Property<string>("ActiveTime");

                    b.Property<int>("DeactiveDayCount");

                    b.Property<string>("DeactiveTime");

                    b.Property<int>("ExpertID");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<string>("Times");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.Property<int>("WeekDay");

                    b.HasKey("ID");

                    b.HasIndex("ExpertID");

                    b.ToTable("ExpertTimeTemplates");
                });

            modelBuilder.Entity("Nobatgir.Model.Level", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LevelName");

                    b.HasKey("ID");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("Nobatgir.Model.Site", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Domain");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<int>("SiteKindID");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("SiteKindID");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("Nobatgir.Model.SiteDictionary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DictionaryTermID");

                    b.Property<int>("SiteID");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("DictionaryTermID");

                    b.HasIndex("SiteID");

                    b.ToTable("SiteDictionaries");
                });

            modelBuilder.Entity("Nobatgir.Model.SiteKind", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.ToTable("SiteKinds");
                });

            modelBuilder.Entity("Nobatgir.Model.SiteKindDictionary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DictionaryTermID");

                    b.Property<int>("SiteKindID");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("DictionaryTermID");

                    b.HasIndex("SiteKindID");

                    b.ToTable("SiteKindDictionaries");
                });

            modelBuilder.Entity("Nobatgir.Model.SiteKindSetting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key");

                    b.Property<int>("SiteKindID");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("SiteKindID");

                    b.ToTable("SiteKindSettings");
                });

            modelBuilder.Entity("Nobatgir.Model.SiteSetting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key");

                    b.Property<int>("SiteID");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("SiteID");

                    b.ToTable("SiteSettings");
                });

            modelBuilder.Entity("Nobatgir.Model.SourceType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExpertID");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("ExpertID");

                    b.ToTable("SourceTypes");
                });

            modelBuilder.Entity("Nobatgir.Model.SourceValue", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<int>("SourceTypeID");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("SourceTypeID");

                    b.ToTable("SourceValues");
                });

            modelBuilder.Entity("Nobatgir.Model.Turn", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExpertID");

                    b.Property<DateTime>("RegDate");

                    b.Property<int>("Status");

                    b.Property<string>("Time");

                    b.Property<DateTime>("TurnDate");

                    b.HasKey("ID");

                    b.HasIndex("ExpertID");

                    b.ToTable("Turns");
                });

            modelBuilder.Entity("Nobatgir.Model.AdminMenu", b =>
                {
                    b.HasOne("Nobatgir.Model.SiteKind", "SiteKind")
                        .WithMany()
                        .HasForeignKey("SiteKindID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.Category", b =>
                {
                    b.HasOne("Nobatgir.Model.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.CategorySetting", b =>
                {
                    b.HasOne("Nobatgir.Model.Category", "Category")
                        .WithMany("CategorySettings")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.Expert", b =>
                {
                    b.HasOne("Nobatgir.Model.Category", "Category")
                        .WithMany("Experts")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.ExpertField", b =>
                {
                    b.HasOne("Nobatgir.Model.Expert", "Expert")
                        .WithMany()
                        .HasForeignKey("ExpertID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nobatgir.Model.SourceType", "SourceType")
                        .WithMany()
                        .HasForeignKey("SourceTypeID");
                });

            modelBuilder.Entity("Nobatgir.Model.ExpertSetting", b =>
                {
                    b.HasOne("Nobatgir.Model.Expert", "Expert")
                        .WithMany("ExpertSettings")
                        .HasForeignKey("ExpertID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.ExpertTimeTemplate", b =>
                {
                    b.HasOne("Nobatgir.Model.Expert", "Expert")
                        .WithMany("ExpertTimeTemplates")
                        .HasForeignKey("ExpertID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.Site", b =>
                {
                    b.HasOne("Nobatgir.Model.SiteKind", "SiteKind")
                        .WithMany("Sites")
                        .HasForeignKey("SiteKindID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.SiteDictionary", b =>
                {
                    b.HasOne("Nobatgir.Model.DictionaryTerm", "DictionaryTerm")
                        .WithMany()
                        .HasForeignKey("DictionaryTermID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nobatgir.Model.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.SiteKindDictionary", b =>
                {
                    b.HasOne("Nobatgir.Model.DictionaryTerm", "DictionaryTerm")
                        .WithMany()
                        .HasForeignKey("DictionaryTermID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nobatgir.Model.SiteKind", "SiteKind")
                        .WithMany("SiteKindDictionaries")
                        .HasForeignKey("SiteKindID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.SiteKindSetting", b =>
                {
                    b.HasOne("Nobatgir.Model.SiteKind", "SiteKind")
                        .WithMany()
                        .HasForeignKey("SiteKindID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.SiteSetting", b =>
                {
                    b.HasOne("Nobatgir.Model.Site", "Site")
                        .WithMany("SiteSettings")
                        .HasForeignKey("SiteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.SourceType", b =>
                {
                    b.HasOne("Nobatgir.Model.Expert", "Expert")
                        .WithMany()
                        .HasForeignKey("ExpertID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.SourceValue", b =>
                {
                    b.HasOne("Nobatgir.Model.SourceType", "SourceType")
                        .WithMany("SourceValues")
                        .HasForeignKey("SourceTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.Turn", b =>
                {
                    b.HasOne("Nobatgir.Model.Expert", "Expert")
                        .WithMany()
                        .HasForeignKey("ExpertID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
