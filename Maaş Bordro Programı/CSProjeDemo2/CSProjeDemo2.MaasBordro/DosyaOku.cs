using System.Text.Json;
using System.Collections.Generic;
using System.IO;

namespace CSProjeDemo2.MaasBordro
{
	public class DosyaOku
	{
		public List<Personel> JsonDosyasindanOku(string filePath)
		{
			try
			{
				if (!File.Exists(filePath))
				{
					throw new FileNotFoundException($"The file was not found: {filePath}");
				}

				var jsonString = File.ReadAllText(filePath);
				return JsonSerializer.Deserialize<List<Personel>>(jsonString);
			}
			catch (Exception ex)
			{
				
				Console.WriteLine($"An error occurred: {ex.Message}");
				return null; 
			}
		}
	}


}

