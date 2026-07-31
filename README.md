

Markdown

````
# 🏦 Digital Wallet & Bank System (OOP Mini-Project)

A robust, console-based banking and digital wallet management system built with **C# (.NET)**. This project serves as a practical implementation of **Object-Oriented Programming (OOP)** concepts and the **Single Responsibility Principle (SRP)**, ensuring scalable, clean, and maintainable code.

---

## 🎯 Project Overview
This system simulates real-world financial operations, allowing users to create bank accounts, perform transactions (deposit, withdraw, transfer), and manage a linked digital wallet. The core focus of this project is **software architecture**—specifically, avoiding "God Classes" by delegating responsibilities to dedicated manager classes (`BankManager`, `WalletManager`).

## ✨ Key Features
- **User Management:** Register users with validation for names, emails, and phone numbers.
- **Account Types:** Supports polymorphic bank accounts (`SavingAccount`, `CheckingAccount`) with unique business logic (e.g., withdrawal fees for saving accounts).
- **Digital Wallet:** Create wallets, link them to specific bank accounts, and seamlessly top-up funds directly from the bank.
- **Transaction History:** Every financial operation automatically generates an immutable `Transaction` record (Deposit, Withdraw, Transfer) with timestamps and unique IDs.
- **Interactive CLI:** A user-friendly console menu to interact with the system continuously.

---

## 🏗️ Architecture & Design Principles

This project heavily utilizes clean coding practices:

- **Single Responsibility Principle (SRP):** 
  - `BankManager` strictly handles bank accounts and transfers.
  - `WalletManager` acts as an orchestrator for wallet operations and talks to the `BankManager` when cross-domain logic is needed (e.g., Top-Up).
  - `User` handles only identity data.
- **Encapsulation:** Object states (like `Balance` and `MyTransactions`) are protected from arbitrary external modifications.
- **Abstraction & Polymorphism:** An abstract `BankAccount` base class defines the contract, while derived classes (`SavingAccount`, `CheckingAccount`) implement their specific `Withdraw` logic.

---

## 📂 Project Structure

```text
📁 Entities
 ┣ 📄 User.cs              # User profile and identity validation
 ┣ 📄 BankAccount.cs       # Abstract base class for all accounts
 ┣ 📄 SavingAccount.cs     # Applies fees on withdrawals
 ┣ 📄 CheckingAccount.cs   # Standard withdrawal logic
 ┣ 📄 BankManager.cs       # Handles account creation & secure transfers
 ┣ 📄 DigitalWallet.cs     # Wallet entity with linked bank account logic
 ┣ 📄 WalletManager.cs     # Orchestrates wallet creation and top-ups
 ┗ 📄 Transaction.cs       # Immutable transaction record
📁 Enum
 ┗ 📄 TransactionType.cs   # Deposit, Withdraw, Transfer
📄 Program.cs              # Interactive UI (Console Menu)
````

##  Getting Started

### Prerequisites

- **.NET 6.0** or higher installed on your machine.
    
- An IDE like Visual Studio 2022, Rider, or VS Code.
    

### Installation & Run

1. Clone the repository:
    
    Bash
    
    ```
    git clone [https://github.com/[AbdallahNasrat](https://github.com/AbdallahNasrat)/Digital-Wallet-Bank-System.git](https://github.com/[AbdallahNasrat](https://github.com/AbdallahNasrat)/Digital-Wallet-Bank-System.git)
    ```
    
2. Navigate to the project directory:
    
    Bash
    
    ```
    cd Digital-Wallet-Bank-System
    ```
    
3. Build and Run the application:
    
    Bash
    
    ```
    dotnet run
    ```
    

##  Usage Example

Upon running the application, you will be greeted with an interactive menu. Here is a typical flow:

1. **Create User:** Enter your details to generate a unique User ID.
    
2. **Open Bank Account:** Use your User ID to open a Checking or Saving account.
    
3. **Open Digital Wallet:** Provide your User ID and Bank Account ID to link them securely.
    
4. **Top-Up Wallet:** Transfer funds directly from your linked bank account to your digital wallet using the `WalletManager`.
    
