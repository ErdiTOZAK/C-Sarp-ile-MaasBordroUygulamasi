using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.MaasBordro
{
	public class Memur : Personel
	{
		public Memur(string name, int workHours)
			: base(name, "Memur", 500, workHours) { }

		public override double MaasHesapla()
		{
			double baseSalary = HourlyRate * Math.Min(WorkHours, 180);
			double overtime = WorkHours > 180 ? (WorkHours - 180) * HourlyRate * 1.5 : 0;
			return baseSalary + overtime;
		}
	}
}
