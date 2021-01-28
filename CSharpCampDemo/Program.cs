using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			// type safety - tip güvenliği
			//değer tutucu
			string kategoriEtiketi = "Kategoriler";
			int ogrenciSayisi = 32000; // int tam sayıları tutar
			double faizOrani = 1.45;    //ondalıklık sayıları gösterir
			bool sistemeGirisYapmisMi = false;
			double dolarDun = 7.45;
			double dolarBugun = 7.45;

			if (dolarDun > dolarBugun)
			{
				Console.WriteLine("Azalış butonu");
			}
			else if (dolarDun < dolarBugun)
			{
				Console.WriteLine("Artış butonu");
			}
			else
			{
				Console.WriteLine("değişmedi butonu");
			}



			if (sistemeGirisYapmisMi == true)
			{
				Console.WriteLine("Kulanıcı ayarları butonu");
			}
			else
			{
				Console.WriteLine("Giris yap butonu");
			}


			Console.WriteLine(kategoriEtiketi);

		}
	}
}
