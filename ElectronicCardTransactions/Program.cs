using ElectronicCardTransactions;
using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var cards = ProcessFile("EC.csv");

			foreach (var item in cards.Take(10))
			{
				Console.WriteLine(item);
			}
		}
		private static IEnumerable<ElectricCards> ProcessFile(string path)
		{
			return File.ReadAllLines(path)
			    .Skip(1)
				.Where(x => x.Length > 0)
				.Select(ElectricCards.ProcessCSVLine);
		}
	}
}