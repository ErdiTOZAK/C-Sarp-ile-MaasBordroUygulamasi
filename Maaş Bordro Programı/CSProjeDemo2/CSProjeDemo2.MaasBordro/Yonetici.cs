using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.MaasBordro
{
	public class Yonetici : Personel
	{
		public double Bonus { get; set; }

		public Yonetici(string name, double hourlyRate, int workHours, double bonus)
			: base(name, "Yonetici", hourlyRate, workHours)
		{
			if (hourlyRate < 500)
				throw new ArgumentException("Yönetici saatlik ücreti 500'den az olamaz.");

			Bonus = bonus;
		}

		public override double MaasHesapla()
		{
			return HourlyRate * WorkHours + Bonus;
		}
	}
}
