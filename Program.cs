using System;

namespace Todolist
{
    class ToDoTask
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        bool IsCompleted { get; set; }
        public ToDoTask (int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            IsCompleted = false;
        }
    }
    class Program
    {
        //to-do a list to store tasks and return them and methods to do so (maybe i will make another class for management (IDK --\(-_-)/--))
        static void Main(string[] args)
        {
            Console.WriteLine("AAD Sends Regards");
            Console.ReadLine();
        }
    }
}