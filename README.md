🍔 Carrols Restaurant Group (CRG) Terminal Ordering System
This is a C# console application that simulates an interactive ordering system for restaurant brands under the Carrols Restaurant Group, such as Burger King and Popeyes. Users can select menu items, review their receipt, remove items, and view a subtotal — all through a friendly terminal interface.

📌 Features
✅ Object-Oriented Design (Inheritance, Overriding)

✅ Dynamic menu display for different restaurant brands

✅ Interactive order-taking with input validation

✅ Optional removal of items before finalizing order

✅ Subtotal calculation and receipt generation

✅ Receipt saved to a local text file for logging

✅ Strong use of C# fundamentals (arrays, loops, exception handling, StreamWriter I/O)

🏗️ Structure
CarrolsRG.cs: Contains base class CarrolsRG and its subclasses BK (Burger King) and Popeyes, each with their own menu.

main.cs: Entry point of the program, where user interaction, order management, and file output happen.

🖥️ How to Use
Clone the repository and open it in a C# IDE (e.g., Visual Studio).

Ensure the TextFile1.txt path exists or update the path in main.cs.

Run the application.

Follow on-screen prompts to:

Choose menu items

Confirm selections

Remove items if needed

Get a subtotal and receipt

🧠 Concepts Demonstrated
Inheritance and polymorphism

Method overriding (virtual and override)

Exception handling with fallback prompts

User input validation in loops

File I/O (System.IO.StreamWriter)

Array manipulation and tracking dynamic lists

💡 Why This Project?
This project was built to practice real-world programming skills in a restaurant-like scenario, simulating an ordering system that might be used in kiosks or backend order processing tools. It combines OOP design, user interaction, and file handling into one cohesive application , a solid demo of C# fundamentals in action.

🔧 Potential Improvements
Add support for multiple restaurants in one session

Enhance UI with a GUI using WinForms or WPF

Store menu data in JSON or a database for easier scaling

Add sales tax and discounts

Unit testing for order logic

👨‍💻 Author
Pablo Gomez
📍 Charlotte, NC
📫 pablogomez88050@gmail.com
