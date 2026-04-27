using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using var db = new AppDbContext();

        // CREATE
        var user = new User
        {
            Name = "Hridoy",
            Orders = new List<Order>
            {
                new Order { Amount = 500 },
                new Order { Amount = 1000 }
            }
        };

        db.Users.Add(user);
        db.SaveChanges();

        Console.WriteLine("User Inserted!");

        // READ (with relationship)
        var users = db.Users
            .Include(u => u.Orders)
            .ToList();

        foreach (var u in users)
        {
            Console.WriteLine($"{u.Id} - {u.Name}");

            foreach (var o in u.Orders)
            {
                Console.WriteLine($"   Order: {o.Amount}");
            }
        }

        // UPDATE
        var firstUser = db.Users.FirstOrDefault();
        if (firstUser != null)
        {
            firstUser.Name = "Updated Name";
            db.SaveChanges();
        }

        // DELETE
        var deleteUser = db.Users.FirstOrDefault();
        if (deleteUser != null)
        {
            db.Users.Remove(deleteUser);
            db.SaveChanges();
        }
    }
}