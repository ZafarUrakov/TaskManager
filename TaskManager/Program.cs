
internal class Program
{
    static List<string> tasks = new List<string>();
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Task Manager!");

        while (true)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. View tasks");
            Console.WriteLine("2. Add a task");
            Console.WriteLine("3. Mark a task as done");
            Console.WriteLine("4. Exit");

            Console.Write("Action: ");
            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    DisplayTasks();
                    break;
                case "2":
                    AddTask();
                    break;
                case "3":
                    MarkTaskAsDone();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
        }
    }


    private static void DisplayTasks()
    {
        Console.Clear();
        Console.WriteLine("Task list:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No task.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1} {tasks[i]}");
            }
        }
    }

    private static void AddTask()
    {
        Console.Clear();
        Console.Write("Enter a new task: ");
        string newTask = Console.ReadLine()!;

        tasks.Add(newTask);
        Console.WriteLine("Task successfully added!");
    }

    private static void MarkTaskAsDone()
    {
        Console.Clear();
        DisplayTasks();

        Console.Write("\nEnter the number of the task you want to mark as done: ");

        int taskIndex = int.Parse(Console.ReadLine()!) - 1;

        if (taskIndex >= 0 && taskIndex < tasks.Count)
        {
            tasks.RemoveAt(taskIndex);
            Console.WriteLine("Task successfully marked as done!");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}