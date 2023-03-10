// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UlkelerDunyasi.Data;

#nullable disable

namespace UlkelerDunyasi.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20221229113412_Ilk")]
    partial class Ilk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UlkelerDunyasi.Data.Ulke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Ulkeler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Türkiye"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "ABD"
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Kanada"
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Norveç"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
