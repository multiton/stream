using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;

namespace Stream.DAL.EntityFramework.Migrations
{
    [DbContext(typeof(CoreDataContext))]
    partial class CoreDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Stream.Domain.Entity.Product.Category", b =>
            {
                b.Property<Guid>("Id").ValueGeneratedOnAdd();

                b.Property<bool>("Disabled");

                b.Property<string>("Name").IsRequired().HasAnnotation("MaxLength", 255);

                b.Property<Guid?>("ParentId");

                b.HasKey("Id");
            });

            modelBuilder.Entity("Stream.Domain.Entity.Product.Item", b =>
            {
                b.Property<Guid>("Id").ValueGeneratedOnAdd();

                b.Property<string>("Name").IsRequired().HasAnnotation("MaxLength", 255);

                b.HasKey("Id");
            });

            modelBuilder.Entity("Stream.Domain.Entity.Product.Category", b =>
            {
                b.HasOne("Stream.Domain.Entity.Product.Category").WithMany().HasForeignKey("ParentId");
            });
        }
    }
}