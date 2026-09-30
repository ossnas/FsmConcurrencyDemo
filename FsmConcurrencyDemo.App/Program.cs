
using FsmConcurrencyDemo.Core.Work;
namespace FsmConcurrencyDemo.App;

internal class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("=== FSM + Multithreading + OOP Demo ===");

		var threads = new List<Thread>();

		// Demonstrate preemptive scheduling
		for (int i = 0; i < 3; i++)
		{
			int id = i;
			var strategy = WorkFactory.Create(i % 2 == 0 ? "cpu" : "io");

			var thread = new Thread(() =>
			{
				var worker = new Worker(id, strategy);
				worker.Run();
			})
			{
				Priority = i == 0 ? ThreadPriority.Highest : ThreadPriority.Normal
			};

			threads.Add(thread);
		}

		threads.ForEach(t => t.Start());
		threads.ForEach(t => t.Join());

		Console.WriteLine("\n=== Task-based concurrency demo ===");

		var tasks = Enumerable.Range(0, 3).Select(i =>
		{
			var strategy = WorkFactory.Create("cpu");
			return Task.Run(() =>
			{
				var worker = new Worker(i + 10, strategy);
				worker.Run();
			});
		}).ToArray();

		Task.WaitAll(tasks);

		Console.WriteLine("\nDemo complete. Press any key to exit.");
		Console.ReadKey();
	}
}

