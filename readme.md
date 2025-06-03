# E-Shop

> A simple desktop shop management system with GUI using Windows Forms, built as part of an academic assignment.

## Features

- GUI-based Windows Forms interface
- Add and manage buyers and sellers
- Add products to sellers and buyers
- Display all users and their details
- Save/load user and product data to files
- Handle special products with extra logic
- Order history management for buyers
- Organized file structure for maintainability

## Project Structure


📁 Forms/
│ ├── MainForm.cs – Main application window
│ ├── FormAddUser.cs – Add new buyers or sellers
│ ├── FormAddProductToSeller.cs – Add products to sellers
│ ├── FormAddProductToBuyer.cs – Add products to buyers
│ └── FormShowAll.cs – Display all users

📁 Classes/
│ ├── Management.cs – Core logic for managing users/products
│ ├── Buyer.cs – Buyer model
│ ├── Seller.cs – Seller model
│ ├── User.cs – Base user class
│ ├── Product.cs – Product class
│ ├── SpecialProduct.cs – Subclass with additional attributes
│ ├── Order.cs – Order/cart management
│ └── Address.cs – Address details for users

ProgramGUI.cs – Entry point of the application, handles file I/O


## Getting Started

1. Clone or download the project.
2. Open the `EShop.sln` solution in Visual Studio (2017 or newer).
3. Make sure `ProgramGUI.cs` is set as the startup file.
4. Build and run the project.

## Prerequisites

- Visual Studio 2017 or newer
- .NET Framework 4.7.2

## Usage

- Use the main menu to add buyers, sellers, and products.
- View all users and their details in a structured table.
- Data is saved to and loaded from text files located at:  
  `bin/Debug/Resources/`

## License

For educational use only.

## Running the Project

To run the application:

1. Clone the repository or download the ZIP.
2. Open the `EShop.sln` solution file in **Visual Studio**.
3. Make sure the startup project is set to `ProgramGUI.cs`:
   - Right-click `ProgramGUI.cs` → Set as Startup Object.
4. Build the solution (`Ctrl+Shift+B` or via the Build menu).
5. Run the project (`F5` or click the Start button).

**Note:**  
All saved data will be stored in the `bin/Debug/Resources/` directory.
