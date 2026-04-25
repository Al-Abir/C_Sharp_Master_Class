using System;
using System.Collections;
using System.Collections.Generic;

class Box<T> where T : class
{
    public T Value;

     public T GetValue()
    {
        return Value;
    }

    public void Show<U>(U data)
    {
        Console.WriteLine("Generic Mehtod " + data);
    }

    public U Show2<U>(U data)
{
    return data;
}

}

class Program
{
    static void Main()
    {
        
     Box<string> box = new Box<string>();
     box.Value = "Hello";
     Console.WriteLine("Value: "+ box.Value);

     //Generic Method
     box.Show<int>(100);
     int a=   box.Show2<int>(56);
     Console.WriteLine("Geneice method " + a);


     //built in generic data structures

     List<int> number = new List<int>();
     number.Add(1);
     number.Add(2);

     Console.WriteLine("List: ");

     foreach(var  n in number)
        {
            Console.WriteLine(n);
        }

        // 🔸 Non-Generic Collection
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Text");

      
        Console.WriteLine("ArrayList:");
        foreach (var item in list)
            Console.WriteLine(item);
    }
}