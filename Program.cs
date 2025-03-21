using System;

namespace Todolist
{
    class ToDoTask
    {        
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public ToDoTask (string title, string description)
        {            
            Title = title;
            Description = description;
            IsCompleted = false;
        }
    }
    class Program
    {        
        List<ToDoTask> tasks = new List<ToDoTask>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1: Display Lists \n2: Make a new Task\n3:delete a task");
                int choice;
                while (!int.TryParse(Console.ReadLine(),out choice) || choice > 3 || choice < 1)
                {
                    Console.WriteLine("Invalid choice, please try again");
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Displaying Lists");
                        break;
                    case 2:
                        Console.WriteLine("Make a new Task");
                        break;
                    case 3:
                        Console.WriteLine("delete a task");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}