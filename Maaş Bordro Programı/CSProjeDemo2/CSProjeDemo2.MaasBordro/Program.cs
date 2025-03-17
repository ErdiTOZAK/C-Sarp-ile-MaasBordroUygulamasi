

using CSProjeDemo2.MaasBordro;
using Newtonsoft.Json;

internal class Program
{
	private static void Main(string[] args)
	{
		DosyaOku dosyaOku = new DosyaOku();
		var personelListesi = dosyaOku.JsonDosyasindanOku("personel.json");

		MaasBordro.BordroOlustur(personelListesi);

		Console.WriteLine("Maaş hesaplamaları tamamlandı.");
		foreach (var personel in personelListesi)
		{
			if (personel.WorkHours < 150)
			{
				Console.WriteLine($"Az Çalışan: {personel.Name}, Çalışma Saati: {personel.WorkHours}");
			}


		}
	}
}