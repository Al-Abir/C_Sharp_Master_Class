using System;
using System.IO;

class Program
{
    static void Main()
    {
        // 📁 Base path (important fix)
        string basePath = Directory.GetCurrentDirectory();

        // 📁 Folder path (safe way)
        string folderPath = Path.Combine(basePath, "Logs");
      
        Console.WriteLine(folderPath);

        // 1️⃣ Directory (create if not exists)
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Folder created!");
        }

        // 2️⃣ DirectoryInfo
        DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
        Console.WriteLine($"Full Path: {dirInfo.FullName}");

        // 📄 File path
        string filePath = Path.Combine(folderPath, "app_log.txt");

        // 3️⃣ File (create যদি না থাকে)
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "=== Log Start ===\n");
        }

        // 4️⃣ FileInfo (updated after write)
        FileInfo fileInfo = new FileInfo(filePath);

        // 🧵 5️⃣ Write using StreamWriter
        using (StreamWriter writer = new StreamWriter(filePath, append: true))
        {
            writer.WriteLine("\n--- New Entry ---");
            writer.WriteLine($"Time: {DateTime.Now}");
            writer.WriteLine("Message: Learning C# File Handling");
        }

        Console.WriteLine("Data written!");

        // 🧵 6️⃣ Read using StreamReader
        Console.WriteLine("\n--- File Content ---\n");

        using (StreamReader reader = new StreamReader(filePath))
        {
            string? line; // null safety

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        // 🔁 FileInfo refresh (VERY IMPORTANT FIX)
        fileInfo.Refresh();

        Console.WriteLine("\n--- File Info ---");
        Console.WriteLine($"File Size: {fileInfo.Length} bytes");
        Console.WriteLine($"Created: {fileInfo.CreationTime}");

        // 📁 7️⃣ DirectoryInfo দিয়ে file list
        Console.WriteLine("\n--- Files in Directory ---");

        FileInfo[] files = dirInfo.GetFiles();

        foreach (var file in files)
        {
            Console.WriteLine($"{file.Name} - {file.Length} bytes");
        }
    }
}