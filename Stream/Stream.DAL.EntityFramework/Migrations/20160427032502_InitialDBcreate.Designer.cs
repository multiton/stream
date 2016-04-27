using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Stream.DAL.EntityFramework;

namespace Stream.DAL.EntityFramework.Migrations
{
    [DbContext(typeof(CoreDataContext))]
    [Migration("20160427032502_InitialDBcreate")]
    partial class InitialDBcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Stream.Domain.Entity.Product.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Disabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<Guid?>("ParentId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Stream.Domain.Entity.Product.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Stream.Domain.Entity.Product.Category", b =>
                {
                    b.HasOne("Stream.Domain.Entity.Product.Category")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });
        }
    }
}
