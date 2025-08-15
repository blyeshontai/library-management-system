# Library Management System (C#)

A console-based library management system written in C#.  
This project is designed to practice fundamental programming concepts such as variables, data types, control structures, loops, methods, and object-oriented programming.

---

## Features

- **Search for Books** – Prompt the user for a book title and display whether it is available.
- **Borrowing Limit** – Users can borrow up to 3 books at a time.
- **Check-in / Check-out** – Track if a book is checked out and allow it to be checked back in.
- **Book Collection** – Store and manage a collection of books in memory.

---

## Technologies Used

- C#  
- .NET SDK  
- Visual Studio Code  
- Git / GitHub for version control

---

## How It Works

1. The program starts with a predefined list of books.
2. Users can:
   - Search for a book by title.
   - Borrow a book if it is available (and they haven’t reached the borrowing limit).
   - Return a book to make it available again.
3. The system updates the status of each book in real time during the session.

---

## Example Usage

```
Welcome to the Library Management System!
Choose an option:
1. Search for a book
2. Borrow a book
3. Return a book
4. Exit

Enter your choice: 1
Enter the book title: The Great Gatsby
Book found! It is available.
```

---

## Installation & Setup

1. Clone this repository: `git clone https://github.com/blyeshontai/library-management-system.git`
2. Open the folder in **Visual Studio Code**.
3. Ensure you have the **.NET SDK** installed: You can verify by running `dotnet --version` in the VS Code terminal
   - If it’s not installed, download it from `https://dotnet.microsoft.com/en-us/download`.
5. Run the application: `dotnet run`


---

## License

This project is licensed under the MIT License. 

---

## Future Improvements

- Store book data in a file or database for persistence. 
- Add user authentication and library card system. 
- Build a graphical interface using WPF or web front-end

--- 


## Author

Created by Shontai Blye – aspiring back-end developer


