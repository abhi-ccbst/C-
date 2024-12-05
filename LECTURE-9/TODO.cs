using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static string tasksFile = "tasks.json";

    static void Main(string[] args)
    {
        if (!File.Exists(tasksFile)) 
        {
            File.WriteAllText(tasksFile, "[]");
        }

        while (true)
        {
            Console.WriteLine("\n=== To-Do Task List ===");
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Edit Task");
            Console.WriteLine("4. Mark Task as Completed");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewTasks();
                    break;
                case "2":
                    AddTask();
                    break;
                case "3":
                    EditTask();
                    break;
                case "4":
                    MarkTaskCompleted();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static List<Task> LoadTasks()
    {
        string json = File.ReadAllText(tasksFile);
        return JsonSerializer.Deserialize<List<Task>>(json);
    }

    static void SaveTasks(List<Task> tasks)
    {
        string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(tasksFile, json);
    }

    static void ViewTasks()
    {
        List<Task> tasks = LoadTasks();
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        Console.WriteLine("\n=== Your Tasks ===");
        for (int i = 0; i < tasks.Count; i++)
        {
            string completed = tasks[i].IsCompleted ? "Completed" : "Pending";
            Console.WriteLine($"{i + 1}. {tasks[i].Description} | Deadline: {tasks[i].Deadline} | Status: {completed}");
        }
    }

    static void AddTask()
    {
        Console.Write("Enter task description: ");
        string description = Console.ReadLine();

        Console.Write("Enter deadline (yyyy-mm-dd): ");
        DateTime deadline;
        while (!DateTime.TryParse(Console.ReadLine(), out deadline))
        {
            Console.Write("Invalid date. Please enter a valid deadline (yyyy-mm-dd): ");
        }

        List<Task> tasks = LoadTasks();
        tasks.Add(new Task { Description = description, Deadline = deadline, IsCompleted = false });
        SaveTasks(tasks);

        Console.WriteLine("Task added successfully.");
    }

    static void EditTask()
    {
        List<Task> tasks = LoadTasks();
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to edit.");
            return;
        }

        ViewTasks();

        Console.Write("Enter task number to edit: ");
        int taskNumber;
        while (!int.TryParse(Console.ReadLine(), out taskNumber) || taskNumber < 1 || taskNumber > tasks.Count)
        {
            Console.Write("Invalid task number. Please enter a valid task number: ");
        }

        Task task = tasks[taskNumber - 1];

        Console.Write($"Enter new description (current: {task.Description}): ");
        string newDescription = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newDescription))
        {
            task.Description = newDescription;
        }

        Console.Write($"Enter new deadline (current: {task.Deadline:yyyy-MM-dd}): ");
        DateTime newDeadline;
        while (!DateTime.TryParse(Console.ReadLine(), out newDeadline))
        {
            Console.Write("Invalid date. Please enter a valid deadline (yyyy-mm-dd): ");
        }
        task.Deadline = newDeadline;

        SaveTasks(tasks);
        Console.WriteLine("Task updated successfully.");
    }

    static void MarkTaskCompleted()
    {
        List<Task> tasks = LoadTasks();
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to mark as completed.");
            return;
        }

        ViewTasks();

        Console.Write("Enter task number to mark as completed: ");
        int taskNumber;
        while (!int.TryParse(Console.ReadLine(), out taskNumber) || taskNumber < 1 || taskNumber > tasks.Count)
        {
            Console.Write("Invalid task number. Please enter a valid task number: ");
        }

        tasks[taskNumber - 1].IsCompleted = true;
        SaveTasks(tasks);
        Console.WriteLine("Task marked as completed.");
    }
}

public class Task
{
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    public bool IsCompleted { get; set; }
}
