using Microsoft.EntityFrameworkCore;
using NorthwindMVC.Models;

namespace NorthwindMVC.Repository
{
    public class PopulateData
    {
        public static void PopulateDatas(IApplicationBuilder app)
        {
            NorthwindContext context = app.ApplicationServices.CreateScope()
                                        .ServiceProvider.GetService<NorthwindContext>();

            if (context.Database.GetPendingMigrations().Any() )
            {
                context.Database.Migrate();
            }

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { CategoryName = "Laptop", Description = "Komputer, laptop,pc", Photo = string.Empty },
                    new Category { CategoryName = "Handphone", Description = "Hp", Photo = string.Empty },
                    new Category { CategoryName = "T-Shirt", Description = "T-Shirt man", Photo = string.Empty }
                    );
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        ProductName = "Monitor LG",
                        Description = "LG 16Inch",
                        CategoryId = 1,
                        Price = 500_000,
                    },
                    new Product
                    {
                        ProductName = "Logitect Mouse 330",
                        Description = "Wireless Silent Click",
                        CategoryId = 1,
                        Price = 159_000
                    },
                    new Product
                    {
                        ProductName = "Keyboard K580",
                        Description = "Slim multidevice for window",
                        CategoryId = 1,
                        Price = 596_000
                    },
                    new Product
                    {
                        ProductName = "Xiomi Redmi Note 10Pro",
                        Description = "Xiomi Amoled 6.67Inch",
                        CategoryId = 2,
                        Price = 599_000
                    },
                    new Product
                    {
                        ProductName = "PowerBank Magsafe",
                        Description = "Anker PowerCore 5k",
                        CategoryId = 2,
                        Price = 335_000
                    },
                    new Product
                    {
                        ProductName = "Chino Pendek",
                        Description = "Chino pendek pria dewasa",
                        CategoryId = 3,
                        Price = 34_000
                    },
                    new Product
                    {
                        ProductName = "Kemaja Alisan",
                        Description = "Semua ukuran ada",
                        CategoryId = 3,
                        Price = 76_000
                    },
                     new Product
                     {
                         ProductName = "Kemaja Dony Man",
                         Description = "Kemeja pria lengan pendek",
                         CategoryId = 3,
                         Price = 58_000
                     }
                );
            }


            context.SaveChanges();

        }
    }
}
