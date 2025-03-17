using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.MaasBordro
{

	public abstract class Personel
	{
		public string Name { get; set; }
		public string Title { get; set; }
		public double HourlyRate { get; set; }
		public int WorkHours { get; set; }

		public Personel(string name, string title, double hourlyRate, int workHours)
		{
			Name = name;
			Title = title;
			HourlyRate = hourlyRate;
			WorkHours = workHours;
		}

		public abstract double MaasHesapla();
	}
}
