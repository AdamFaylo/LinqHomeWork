using LinqHomeWork;
using System;

namespace MyApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var animals = ProcessFile("class.csv");

			foreach (var animal in animals)
			{
				Console.WriteLine(animal);
			}
		}
		private static IEnumerable<ZooAnimal> ProcessFile(string path)
		{
			return File.ReadAllLines(path)
				.Skip(1)
				.Where(a => a.Length > 0)
				.Select(ZooAnimal.ProcessCSVLine).ToList();
		}
	}
}