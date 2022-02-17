using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{

    //есть класс, у которого есть имя и зависимости
    //он не должен быть запущен раньше чем зависимость
    //то есть Таска А должна быть запущена после В и С
    //а С и Д могут быть запущены сразу и не важно в каком порядке
    public static class CustomTaskMain
    {
        
        public static void Main()
        {
            //[Task('A', ['B', 'C']), Task('B', ['C']), Task('C', []), Task('D', [])]
            var taskA = new CustomTask("A", new List<string> { "B", "C" });
            var taskB = new CustomTask("B", new List<string> { "C" });
            var taskC = new CustomTask("C");
            var taskD = new CustomTask("D");
            CustomTask.tasks = new List<CustomTask> { taskA, taskB, taskC, taskD };
            CustomTask.Run();

            Console.ReadKey();
        }

        public static void Main2()
        {
            var taskA = new CustomTask("A");
            var taskB = new CustomTask("B", new List<string> { "C" });
            var taskC = new CustomTask("C", new List<string> { "D", "A" });
            var taskD = new CustomTask("D");
            CustomTask.tasks = new List<CustomTask> { taskA, taskB, taskC, taskD };
            //CustomTask.TopologicalSort();
            CustomTask.Run();

            Console.ReadKey();
        }
    }

    public class CustomTask
    {
        public static Queue<CustomTask> queue = new();
        public static List<CustomTask> tasks;
        public static List<string> launchedTasks = new ();

        public bool IsVisited { get; set; }
        public bool IsLaunched { get; set; }
        public string Name { get; set; }
        public List<string> Deps { get; set; }

        public CustomTask(string name, List<string> deps = null)
        {
            Name = name;
            Deps = deps ?? new List<string>();
        }

        public override string ToString()
        {
            return Name;
        }

        //public static void TopologicalSortUtil(int v)
        //{
        //    tasks[v].IsVisited = true;

        //    foreach (var vertex in tasks[v].Deps)
        //    {
        //        var vertexTask = tasks.First(t => t.Name == vertex);
        //        if (!tasks[v].IsVisited)
        //            TopologicalSortUtil(Array.IndexOf(tasks, vertexTask));
        //    }

        //    queue.Enqueue(tasks[v]);
        //}

        //public static void TopologicalSort()
        //{
        //    for (int i = 0; i < tasks.Length; i++)
        //    {
        //        if (!tasks[i].IsVisited)
        //            TopologicalSortUtil(i);
        //    }

        //    // Print contents of stack
        //    foreach (var vertex in queue)
        //    {
        //        Console.Write(vertex + " ");
        //    }
        //}

        public static void Run()
        {
            tasks = tasks.OrderBy(t => t.Deps.Count).ToList();

            while (launchedTasks.Count != tasks.Count)
            {
                foreach (var task in tasks.Where(t => !t.IsLaunched && 
                    t.Deps.All(d => launchedTasks.Contains(d))))
                {
                    Console.WriteLine(task);
                    task.IsLaunched = true;
                    launchedTasks.Add(task.Name);
                }
            }
        }
    }
}
