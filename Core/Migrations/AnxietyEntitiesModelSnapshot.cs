// <auto-generated />
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Core.Migrations
{
    [DbContext(typeof(AnxietyEntities))]
    partial class AnxietyEntitiesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Models.Anxiety_RegPatient", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Pid"), 1L, 1);

                    b.Property<string>("Paddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Page")
                        .HasColumnType("int");

                    b.Property<string>("Pbloodgroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pcity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pcontact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pdob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pemail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pfirstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pgender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ppassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prefferalname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pstate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rid")
                        .HasColumnType("int");

                    b.HasKey("Pid");

                    b.ToTable("Anxiety_RegPatients");
                });
#pragma warning restore 612, 618
        }
    }
}
