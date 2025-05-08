
# 📓 Digital Diary (C# Console Application)

## 📌 Project Description  
**Digital Diary** is a console-based C# application that allows users to write, view, delete, modify, and search diary entries. It demonstrates effective file handling and object-oriented programming principles. All entries are timestamped and stored in a local text file (`diary.txt`).

---

## ✨ Features
- ✍️ Write new diary entries with automatic timestamps  
- 📖 View all saved entries  
- 🔍 Search entries by date (`YYYY-MM-DD` format)  
- ✏️ Modify existing entries  
- 🖥️ Clean and user-friendly console interface  

---

## 🔧 How OOP Principles Are Used

- **Encapsulation**: Internal file handling logic is managed within the `Diary` class using private fields and public methods.  
- **Abstraction**: Complex operations like writing or searching entries are simplified through user-facing methods like `WriteEntry()` and `SearchByDate()`.  
- **Modularity**: Code is split across multiple files to improve organization and readability.  
- **Inheritance & Polymorphism** *(optional)*: These can be extended in future versions for more entry types or UI commands.

---

## ▶️ Instructions on Running the App

1. **Install** [.NET SDK 6.0 or later](https://dotnet.microsoft.com/en-us/download).
2. **Clone** this repository:
   ```bash
   git clone https://github.com/your-username/digital-diary.git
3. **Navigate** to the project directory:
   ```bash
   cd digital-diary
4. **Build and run** the app:
   ```bash
   dotnet run
   

## 🗂️ File Structure
```bash 
DigitalDiary/
├── Program.cs         // Main menu and user interaction
├── Diary.cs           // Diary class with file operations
├── diary.txt          // Automatically created text file for entries
└── README.md          // Project documentation
```
## 📷 Sample Output
```bash
Diary Application
1. Write Entry
2. View All Entries
3. Search Entry by Date
4. Modify an Entry
5. Exit
Enter choice: 1
Enter your diary entry: Learned about StreamReader today.
Entry saved successfully.

Entries:
1. 2025-04-25 16:00:00 | Learned about StreamReader today.

Enter choice: 4
Enter entry number to modify: 1
Enter new text: Reviewed StreamWriter too.
Entry modified successfully.

```

# 👥 Team Members

- John Timothy Caranza

- Jan Mayen Mallen

- Theodore Von Bunquin

- Justin Miguel Antenor

# 🙏 Acknowledgement

Special thanks to our CS 222 instructor and team members for their dedication and persistence throughout development.
