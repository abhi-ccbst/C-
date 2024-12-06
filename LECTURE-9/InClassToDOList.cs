using System.ComponentModel;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Xml;

namespace InClassTODOList {
    public abstract class FileManagement {
        public string TaskFile {set; get;}
        public Names PersonName {set; get;}
        public FileManagement(string fileLocation, Names names) {
            TaskFile = fileLocation;
            PersonName = names;
        }
        public abstract void AddTask();
        public abstract List<Task> LoadTasks();

        public abstract void SaveTasks(List<Task> tasks);
        public abstract void ViewTasks();

        public abstract void EditTask();
        public abstract void MarkTaskCompleted();
    }

    public class FileManagementInfo : FileManagement
    {
        public FileManagementInfo(string localtion, Names name): base(localtion, name) {

        }
        /**
        * This method add new Task in existing tasks
        */
        public override void AddTask()
        {
            Console.Write("Enter task description: ");
            string description = Console.ReadLine();
            Console.Write("Enter deadline (yyyy-mm-dd): ");
            DateTime dateTime;
            while (!DateTime.TryParse(Console.ReadLine(), out dateTime) || dateTime < DateTime.Now) {
                Console.Write("[ERROR] Invalid date. Please enter a valid deadline (yyyy-mm-dd): ");
            }
            List<Task> tasks = LoadTasks();
            tasks.Add(new Task(PersonName, description, dateTime, false, DateTime.Now, DateTime.Now));
            SaveTasks(tasks);
            Console.WriteLine("Task added successfully");
        }

        public override void EditTask()
        {
            List<Task> tasks = LoadTasks();
            if (tasks.Count == 0) {
                Console.WriteLine("No tasks to edit");
                return;
            }
            ViewTasks();
            Console.Write($"Enter task number[1 - {tasks.Count} to edit: ");
            int taskNumber;
            while (!int.TryParse(Console.ReadLine(), out taskNumber) || taskNumber < 1 || taskNumber > tasks.Count) {
                Console.Write($"[ERROR] Invalid task number, Please enter a valid task number[1 - {tasks.Count}]: ");
            }
            Task task = tasks[taskNumber - 1];
            if (task.CreatedBy != PersonName) {
                Console.WriteLine("[ERROR] you are not authorized user!!");
                return;
            }
            Console.Write("Enter task description: ");
            task.Description = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(task.Description)){
                Console.Write("[ERROR] Invalid string. Please enter a valid description: ");
                task.Description = Console.ReadLine();
            }
            Console.Write("Enter deadline (yyyy-mm-dd): ");
            DateTime dateTime;
            while (!DateTime.TryParse(Console.ReadLine(), out dateTime) || dateTime < DateTime.Now) {
                Console.Write("[ERROR] Invalid date. Please enter a valid deadline (yyyy-mm-dd): ");
            }
            Console.Write("Enter task completed (true or false): ");
            bool isCompleted;
            while(!bool.TryParse(Console.ReadLine(), out isCompleted)) {
                Console.Write("[ERROR] Invalid bool. Please enter a valid bool (true or false): ");
            }
            task.DeadLine = dateTime;
            task.UpdatedAt = DateTime.Now;
            task.IsCompleted = isCompleted;
            tasks[taskNumber - 1] = task;
            SaveTasks(tasks);
            Console.WriteLine("Task updated successfully");
        }

        public override List<Task> LoadTasks()
        {
            string json = File.ReadAllText(TaskFile);
            return JsonSerializer.Deserialize<List<Task>>(json);
        }

        public override void MarkTaskCompleted()
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
                Console.Write("[ERROR] Invalid task number. Please enter a valid task number: ");
            }
            if (tasks[taskNumber - 1].CreatedBy != PersonName) {
                Console.WriteLine("[ERROR] you are not authorized user!!");
                return;
            }
            tasks[taskNumber - 1].IsCompleted = true;
            tasks[taskNumber -1 ].UpdatedAt = DateTime.Now;
            SaveTasks(tasks);
            Console.WriteLine("Task marked as completed.");
        }

        public override void SaveTasks(List<Task> tasks)
        {
            string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(TaskFile, json);
        }

        public override void ViewTasks()
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
                Console.WriteLine($"{i + 1}. | CreatedBy: {tasks[i].CreatedBy} | {tasks[i].Description} | Deadline: {tasks[i].DeadLine} | Status: {completed} | CreatedAt: {tasks[i].CreatedAt} | UpdatedAt | {tasks[i].UpdatedAt}");
            }
        }
    }

    public class Task {
        public Names CreatedBy {get; set;}
        public string Description {get; set;}
        public DateTime DeadLine {get; set;}
        public bool IsCompleted {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
        public Task() { }
        public Task(Names names, string description, DateTime deadLine, bool isCompleted, DateTime createdAt, DateTime updatedAt) {
            CreatedBy = names;
            Description = description;
            DeadLine = deadLine;
            IsCompleted = isCompleted;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }   
    }

    public enum Names {
        Abhi,  // 0
        Peter, // 1
        Harry //2
    }

    public class Program 
    {
        static void Main(string[] args) {
            Console.Write("Enter file localtion: ");
            string file = Console.ReadLine();
            Console.Write("Enter your name: ");
            Names name;
            while (!Enum.TryParse(Console.ReadLine(), true, out name))
            {
                Console.Write("[ERROR] Invalid name. Please try again: ");
            }
            if (!File.Exists(file)) 
            {
                File.WriteAllText(file, "[]");
            }

            FileManagement fileManagement = new FileManagementInfo(file, name);
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
                        fileManagement.ViewTasks();
                        break;
                    case "2":
                        fileManagement.AddTask();
                        break;
                    case "3":
                        fileManagement.EditTask();
                        break;
                    case "4":
                        fileManagement.MarkTaskCompleted();
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
    }
}