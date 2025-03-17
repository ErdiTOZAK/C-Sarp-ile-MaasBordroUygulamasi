using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSProjeDemo2.MaasBordro
{
	public class MaasBordro
	{
		public static void BordroOlustur(List<Personel>? personelListesi)
		{
			// personelListesi null mı kontrol et
			if (personelListesi == null)
			{
				Console.WriteLine("Personel listesi null.");
				return;
			}

			string baseFolderPath = @"C:\Users\erdi_\OneDrive\Masaüstü\Maaş Bordro Programı\CSProjeDemo2\personel.json";

			foreach (var personel in personelListesi)
			{
				// personel null mı kontrol et
				if (personel == null)
				{
					Console.WriteLine("Personel nesnesi null.");
					continue; // null olan nesneleri atla
				}

				double maas = personel.MaasHesapla();
				string personelFolderPath = Path.Combine(baseFolderPath, personel.Name);
				Directory.CreateDirectory(personelFolderPath); // Klasör oluştur

				var bordro = new
				{
					MaasBordro = "ŞUBAT 2025",
					PersonelIsmi = personel.Name,
					CalismaSaati = personel.WorkHours,
					AnaOdeme = maas.ToString("C"),
					Mesai = personel.WorkHours > 180 ? (personel.WorkHours - 180) * personel.HourlyRate * 1.5 : 0,
					ToplamOdeme = (maas + (personel.WorkHours > 180 ? (personel.WorkHours - 180) * personel.HourlyRate * 1.5 : 0)).ToString("C")
				};

				string bordroJson = JsonSerializer.Serialize(bordro);
				string bordroFilePath = Path.Combine(@"C:\Users\erdi_\OneDrive\Masaüstü\Maaş Bordro Programı\CSProjeDemo2\personel.json", bordroJson); // JSON dosyasının tam yolu

				File.WriteAllText(bordroFilePath, bordroJson); // JSON dosyasını yaz
			}
		}
	}
	
}
