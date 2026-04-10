
using System;
class Program
{
   static void Main()
   {
       Console.Write("Enter your name: ");
       string name = Console.ReadLine();

       Console.Write("Enter your age: ");
       int age = int.Parse(Console.ReadLine());

       Console.WriteLine("Name: " + name);
       Console.WriteLine("Age: " + age);
       int[] marks = {80, 90, 85};
       Console.WriteLine("First mark: " + marks[0]);
   }
}