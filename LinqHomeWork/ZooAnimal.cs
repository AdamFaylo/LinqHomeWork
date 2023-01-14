using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomeWork
{
	public class ZooAnimal
	{
		public int ClassNumber { get; set; }
		public int NumberOfAnimal { get; set; }
		public string CalssType { get; set; }
		public string AnimalName { get; set; }

		public override string ToString()
		{
			return $"Class Number: {ClassNumber,-1} " +
				   $"| Number Of Animal: {NumberOfAnimal,-3} " +
				   $"| Calss Type: {CalssType,-15} " +
				   $"| AnimalName: {AnimalName}";
		}

		public static ZooAnimal ProcessCSVLine(string line)
		{
			string[] values = line.Split(',');
			return new ZooAnimal
			{
				ClassNumber = int.Parse(values[0]),
				NumberOfAnimal = int.Parse(values[1]),
				CalssType = values[2],
				AnimalName = values[3],
			};
		}

	}
}
