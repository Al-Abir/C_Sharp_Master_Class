using System;

// 🔹 Interface
interface IWorker
{
    void Work();
}

// 🔹 Abstract Class
public abstract class Employee
{
    public string Name { get; set; }

    // virtual method
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Employee: {Name}");
    }

    // abstract method
    public abstract void CalculateSalary();
}

// 🔹 Partial Class (Part 1)
public partial class Developer : Employee, IWorker
{
    public int HoursWorked { get; set; }

    public override void CalculateSalary()
    {
        Console.WriteLine($"Salary: {HoursWorked * 100}");
    }
}

// 🔹 Partial Class (Part 2)
public partial class Developer
{
    // override
    public override void ShowInfo()
    {
        Console.WriteLine($"Developer: {Name}");
    }

    // interface implementation
    public void Work()
    {
        Console.WriteLine("Coding...");
    }

    // sealed override (further override বন্ধ)
    public sealed override string ToString()
    {
        return $"Dev: {Name}";
    }
}

// 🔹 Static Class
static class CompanyHelper
{
    public static void CompanyInfo()
    {
        Console.WriteLine("Company: Tech Corp");
    }
}

// 🔹 new keyword example (method hiding)
class SeniorDeveloper : Developer
{
    public new void Work()
    {
        Console.WriteLine("Designing system...");
    }

    // ShowInfo override করা যাবে (কারণ sealed না)
    public override void ShowInfo()
    {
        Console.WriteLine($"Senior Dev: {Name}");
    }
}

// 🔹 Main Program
class Program
{
    static void Main()
    {
        CompanyHelper.CompanyInfo();

        Developer dev = new Developer()
        {
            Name = "Hridoy",
            HoursWorked = 10
        };

        dev.ShowInfo();        // override
        dev.Work();            // interface
        dev.CalculateSalary(); // abstract

        Console.WriteLine(dev.ToString());

        Console.WriteLine("-----");

        SeniorDeveloper senior = new SeniorDeveloper()
        {
            Name = "Rahim",
            HoursWorked = 12
        };

        senior.ShowInfo(); // override
        senior.Work();     // new (method hiding)
    }
}