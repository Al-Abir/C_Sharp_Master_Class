using System;
using System.Collections.Generic;
using System.IO;

// 🔹 1. ICloneable (object copy)
class User : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public object Clone()
    {
        return new User
        {
            Name = this.Name,
            Age = this.Age
        };
    }
}

class Program
{
    static void Main()
    {
        // 🔹 2. ICollection (add/remove capability)
        ICollection<User> users = new List<User>();

        users.Add(new User { Name = "Abir", Age = 25 });
        users.Add(new User { Name = "Hridoy", Age = 22 });

        // 🔹 3. IEnumerable (loop only)
        IEnumerable<User> userList = users;

        Console.WriteLine("User List:");
        foreach (var u in userList)
        {
            Console.WriteLine($"{u.Name} - {u.Age}");
        }

        // 🔹 4. ICloneable (copy object)
        User original = new User { Name = "Rakib", Age = 30 };
        User copy = (User)original.Clone();

        copy.Name = "Copied User";

        Console.WriteLine("\nOriginal: " + original.Name);
        Console.WriteLine("Copy: " + copy.Name);

        // 🔹 5. IDisposable (StreamWriter auto cleanup)
        string filePath = "users.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var u in users)
            {
                writer.WriteLine($"{u.Name},{u.Age}");
            }
        }

        Console.WriteLine("\nData saved to file!");
    }
}