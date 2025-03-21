using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

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
        static void DisplayListofTasks(List<ToDoTask> Tasks)
        {
            int Id = 1;
            foreach (ToDoTask task in Tasks)
            {
                Console.WriteLine($"Title: {task.Title}");
                Console.WriteLine($"Description: {task.Description}");
                Console.WriteLine($"Is Completed: {task.IsCompleted}");
                Console.WriteLine($"ID : {Id}");
                Console.WriteLine();
                Id++;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }        
        static void Main(string[] args)
        {
            int TaskId;
            string PushTitle;
            string PushDescription;
            List<ToDoTask> tasks = new List<ToDoTask>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1: Display List of tasks \n2: Make a new Task\n3: delete a task\n4: Mark a Task Compelete By ID\n5: Exit");
                int choice;
                while (!int.TryParse(Console.ReadLine(),out choice) || choice > 5 || choice < 1)
                {
                    Console.WriteLine("Invalid choice, please try again");
                }
                //(DANGER) ----
                //Solve the problem of the user entering a string instead of a number and Null
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Displaying Tasks:");
                        DisplayListofTasks(tasks);
                        break;
                    case 2:
                        Console.WriteLine("Making a new Task \nEnter the Title: ");
                        PushTitle = Console.ReadLine();
                        Console.WriteLine("Enter the Description: ");
                        PushDescription = Console.ReadLine();
                        tasks.Add(new ToDoTask(PushTitle, PushDescription));
                        break;
                    case 3:
                        Console.WriteLine("delete a task By ID (ID is): ");
                        TaskId = int.Parse(Console.ReadLine());
                        tasks.RemoveAt(TaskId - 1);
                        break;
                    case 4:
                        Console.WriteLine("Mark a Task Compelete By ID (ID is): ");
                        TaskId = int.Parse(Console.ReadLine());
                        tasks[TaskId - 1].IsCompleted = true;
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}