using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicCardTransactions
{
	public class ElectricCards
	{
		public string SeriesReference { get; set; }
		public double Period { get; set; }
		public double DataValue { get; set; }
		public string Status { get; set; }
		public string Units { get; set; }
		public int Megnitude { get; set; }
		public string Subject { get; set; }
		public string Group { get; set; }
		public string SeriesTite_1 { get; set; }

		public override string ToString()
		{
			return $"{SeriesReference} | {Period} | {DataValue} | {Status} | {Units} | {Megnitude} | {Subject} | {Group} | {SeriesTite_1} |";
		}

		public static  ElectricCards ProcessCSVLine(string line)
		{
			string[] values = line.Split(',');
			return new ElectricCards
			{
				SeriesReference = values[0],
				//Period = double.Parse(values[1]),
				DataValue = double.Parse(values[2]),
				Status = values[3],
				Units = values[4],
				Megnitude = int.Parse(values[5]),
				Subject = values[6], 
				Group = values[7],
				SeriesTite_1 = values[8]
			};
		}
	}
}
