#📦 Stock-Inventory-Management-System-P1



## 📌 Project Overview

The **Inventory Management System** is a console-based backend application developed using **C# and .NET** to efficiently manage products, suppliers, warehouses, and inventory transactions.

The system ensures accurate stock tracking using a **transaction-based approach**, where stock levels are derived from recorded transactions instead of direct updates. This guarantees **data consistency, auditability, and reliability**.

---

## 🎯 Objectives

* Efficiently manage inventory across multiple warehouses
* Maintain accurate stock levels using transactions
* Provide complete audit trails for all operations
* Enable better inventory decision-making through reports

---

## 🏗️ Architecture

This project follows a **3-Layer Architecture**:

```
Presentation Layer (Console UI)
        ↓
Business Logic Layer (Services)
        ↓
Data Access Layer (Entity Framework Core + MYSQL)
```

### ✔️ Benefits:

* Separation of concerns
* Easy maintenance
* Scalable design

---

## 🗂️ Project Structure

```
InventoryManagementSystem/
│
├── ConsoleUI/                     # Presentation Layer
│   ├── CategoryConsole.cs
│   ├── ProductConsole.cs
│   ├── ReportsConsole.cs
│   ├── StockConsole.cs
│   ├── StockTransactionConsole.cs
│   ├── SupplierConsole.cs
│   └── WarehouseConsole.cs
│
├── Models/                        # Entity Models
│   ├── Product.cs
│   ├── ProductCategory.cs
│   ├── ProductSupplier.cs
│   ├── StockLevel.cs
│   ├── StockTransaction.cs
│   ├── Supplier.cs
│   └── Warehouse.cs
│
├── Data/
│   └── InventoryContext.cs        # DbContext
│
├── Services/                      # Business Logic Layer
│   ├── CategoryService.cs
│   ├── ProductService.cs
│   ├── StockService.cs
│   ├── SupplierService.cs
│   └── WarehouseService.cs
│
├── Utilities/
│   └── DbInitializer.cs           # Database seeding
│
├── Migrations/                    # EF Core migrations
│
├── InventoryManagementSystem.Tests/
│   ├── Helpers/
│   ├── ProductServiceTests.cs
│   ├── StockServiceTests.cs
│   └── UnitTest1.cs
│
├── Program.cs
├── InventoryManagementSystem.slnx
├── .gitignore
└── README.md
```

---

## 🚀 Features

### 🔹 Product Management

* Add, update, delete products
* Manage SKU, category, pricing
* Product status (Active / Inactive / Discontinued)

### 🔹 Category Management

* Hierarchical category structure

### 🔹 Supplier Management

* Link products with suppliers
* Maintain supplier-specific product details

### 🔹 Warehouse Management

* Multiple warehouse support
* Track stock per location

### 🔹 Stock Management

* Quantity on hand
* Reorder level
* Safety stock

### 🔹 Stock Transactions

* Purchases
* Sales
* Transfers
* Adjustments
* Returns

✔️ All transactions:

* Are logged
* Maintain audit trail
* Follow ACID principles

### 🔹 Reports & Alerts

* Low stock alerts
* Inventory reports
* Stock tracking history

---

## 🔄 System Workflow

1. User interacts via Console UI
2. Console calls Service layer
3. Services process business logic
4. Data stored via Entity Framework Core
5. Stock levels calculated from transactions

---

## 🧪 Testing

Testing is implemented using **xUnit**:

* ✔️ ProductServiceTests
* ✔️ StockServiceTests
* ✔️ Business logic validation

---

## ⚙️ Technologies Used

| Technology            | Description           |
| --------------------- | --------------------- |
| C#                    | Programming Language  |
| .NET                  | Application Framework |
| MYSQL                 | Database              |
| Entity Framework Core | ORM                   |
| ADO.NET               | Data Access           |
| xUnit                 | Unit Testing          |

---

## 📊 Database Entities

* Product
* ProductCategory
* Supplier
* Warehouse
* StockLevel
* StockTransaction
* ProductSupplier

---

## 📥 Setup & Installation

### 🔧 Prerequisites

* Visual Studio / VS Code
* .NET SDK
* MYSQL 

---

### ▶️ Steps to Run

```bash
# Clone repository
git clone https://github.com/your-username/InventoryManagementSystem.git

# Open in Visual Studio

# Update connection string in appsettings.json

# Apply migrations
Update-Database

# Run application
dotnet run
```

