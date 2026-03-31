using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using System;
using System.Linq;

namespace InventoryManagementSystem.Utilities
{
    public static class DbInitializer
    {
        public static void Seed(InventoryContext context)
        {
            context.Database.EnsureCreated();

            // ---------------- CATEGORY ----------------
            if (!context.ProductCategories.Any())
            {
                var medical = new ProductCategory { CategoryName = "Medical", Description = "Medical supplies and medicines" };
                var electronics = new ProductCategory { CategoryName = "Electronics", Description = "Electronic devices and gadgets" };
                var stationery = new ProductCategory { CategoryName = "Stationery", Description = "Office supplies and stationery" };

                context.ProductCategories.AddRange(medical, electronics, stationery);
                context.SaveChanges();
                Console.WriteLine("Sample Categories Added.");
            }

            var medicalCategory = context.ProductCategories.First(c => c.CategoryName == "Medical");
            var electronicsCategory = context.ProductCategories.First(c => c.CategoryName == "Electronics");

            // ---------------- SUPPLIERS ----------------
            if (!context.Suppliers.Any())
            {
                var medSuppliers = new Supplier { SupplierName = "MedCorp", Email = "contact@medcorp.com", Phone = "123-456-7890" };
                var techSuppliers = new Supplier { SupplierName = "TechWorld", Email = "sales@techworld.com", Phone = "098-765-4321" };

                context.Suppliers.AddRange(medSuppliers, techSuppliers);
                context.SaveChanges();
                Console.WriteLine("Sample Suppliers Added.");
            }

            // ---------------- WAREHOUSES ----------------
            if (!context.Warehouses.Any())
            {
                context.Warehouses.AddRange(
                    new Warehouse { WarehouseName = "Main Store", Location = "Mumbai", Capacity = 5000 },
                    new Warehouse { WarehouseName = "Regional Hub", Location = "Pune", Capacity = 2000 }
                );
                context.SaveChanges();
                Console.WriteLine("Sample Warehouses Added.");
            }

            // ---------------- PRODUCTS ----------------
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        SKU = "MED001",
                        ProductName = "Paracetamol 500mg",
                        CategoryId = medicalCategory.ProductCategoryId,
                        Cost = 1.50m,
                        ListPrice = 5.00m,
                        IsActive = true,
                        UnitOfMeasure = "Box",
                        ReorderLevel = 100
                    },
                    new Product
                    {
                        SKU = "ELE001",
                        ProductName = "Wireless Mouse",
                        CategoryId = electronicsCategory.ProductCategoryId,
                        Cost = 15.00m,
                        ListPrice = 25.00m,
                        IsActive = true,
                        UnitOfMeasure = "Unit",
                        ReorderLevel = 50
                    }
                );
                context.SaveChanges();
                Console.WriteLine("Sample Products Added.");
            }

            Console.WriteLine("Database Seeding Completed.");
        }
    }
}
