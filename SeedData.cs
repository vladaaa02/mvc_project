using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();


            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }


            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Samsung Galaxy S23",
                        Description = "256GB interne memorije; 8GB RAM; Glavna kamera ima 3 kamere: 50 MP, 10 MP i 12 MP; Selfie kamera: 12 MP",
                        Category = "Samsung",
                        Price = 799.99m
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy S23+",
                        Description = "512GB interne memorije; 8GB RAM; Glavna kamera ima 3 kamere: 50 MP, 10 MP i 12 MP; Selfie kamera: 12 MP",
                        Category = "Samsung",
                        Price = 999.99m
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy Z Fold4",
                        Description = "1TB interne memorije; 12GB RAM; Glavna kamera ima 3 kamere: 50 MP, 10 MP i 12 MP; Selfie ima 2 kamere: 4 MP i 10 MP",
                        Category = "Samsung",
                        Price = 1799.99m
                    },
                    new Product
                    {
                        Name = "Poco F5 Pro",
                        Description = "512GB interne memorije; 12GB RAM; Glavna kamera ima 3 kamere: 64 MP, 8 MP i 2 MP; Selfie kamera: 16 MP",
                        Category = "Xiaomi",
                        Price = 499.99m
                    },
                    new Product
                    {
                        Name = "Redmi Note 12 Pro",
                        Description = "256GB interne memorije; 12GB RAM; Glavna kamera ima 3 kamere: 50 MP, 8 MP i 2 MP; Selfie kamera: 16 MP",
                        Category = "Xiaomi",
                        Price = 349.99m
                    },
                    new Product
                    {
                        Name = "Redmi Note 12 Pro+",
                        Description = "256GB interne memorije; 12GB RAM; Glavna kamera ima 3 kamere: 200 MP, 8 MP i 2 MP; Selfie kamera: 16 MP",
                        Category = "Xiaomi",
                        Price = 399.99m
                    },
                    new Product
                    {
                        Name = "iPhone 14 Pro Max",
                        Description = "1TB interne memorije; 6GB RAM; Glavna kamera ima 3 kamere: 48 MP, 12 MP i 12 MP; Selfie kamera: 12 MP",
                        Category = "Apple",
                        Price = 1399.99m
                    },
                    new Product
                    {
                        Name = "iPhone XR",
                        Description = "256GB interne memorije; 3GB RAM; Glavna kamera: 12 MP; Selfie kamera: 7MP",
                        Category = "Apple",
                        Price = 399.99m
                    },
                    new Product
                    {
                        Name = "iPhone 14 Plus",
                        Description = "512GB interne memorije; 6GB RAM; Glavna kamera ima 2 kamere: 2x12 MP; Selfie kamera: 12 MP",
                        Category = "Apple",
                        Price = 999.99m
                    },
                    new Product
                    {
                        Name = "iPhone 14",
                        Description = "512GB interne memorije; 6GB RAM; Glavna kamera: 2x12 MP; Selfie kamera: 12 MP",
                        Category = "Apple",
                        Price = 799.99m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}