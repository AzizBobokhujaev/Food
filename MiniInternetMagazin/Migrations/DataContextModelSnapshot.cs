// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniInternetMagazin.Db;

namespace MiniInternetMagazin.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("MiniInternetMagazin.Models.GroceryStoreViewModels.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryId = 1, CategoryName = "Молочьное" },
                        new { CategoryId = 2, CategoryName = "Мясное" },
                        new { CategoryId = 3, CategoryName = "Фрукты" },
                        new { CategoryId = 4, CategoryName = "Яйцы" },
                        new { CategoryId = 5, CategoryName = "Рыбы" },
                        new { CategoryId = 6, CategoryName = "Зерно-мучное" }
                    );
                });

            modelBuilder.Entity("MiniInternetMagazin.Models.GroceryStoreViewModels.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductName");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MiniInternetMagazin.Models.GroceryStoreViewModels.Product", b =>
                {
                    b.HasOne("MiniInternetMagazin.Models.GroceryStoreViewModels.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
