using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterkezeles
{
	static class Harc
	{
		public static void KarakterHarc(Karakter karakter1, Karakter karakter2)
		{
			bool kiTamad = new Random().Next(0,2) == 0 ? false : true ;
			while (karakter1.Eletero > 0 && karakter2.Eletero > 0)
			{
				Karakter Tamado = kiTamad ? karakter2 : karakter1;
				Karakter Vedekezo = kiTamad ? karakter1 : karakter2;
				int damage = Tamado.Tamad();
				int vedekezes = Vedekezo.Vedekezik();

				damage -= vedekezes;
				if (damage < 0)
				{
					damage = 0;
				}
				Vedekezo.Eletero -= damage;
				Console.WriteLine($"{damage} életerőt vesztett {Vedekezo.Nev}!");
				if (new Random().Next(1, 9) == 1)
				{
					Vedekezo.Gyogyul();
					Console.WriteLine($"{Vedekezo.Nev} sikeresen tudott gyógyitani magán!");
				}
				Console.WriteLine($"A fentmaradt életereje a védekező karakternek: {Vedekezo.Eletero}\n");

				kiTamad = ! kiTamad;
			}

			if (karakter1.Eletero <= 0)
			{
				Console.WriteLine($"{karakter2.Nev} nyerte a harcot!");
			} else
			{
				Console.WriteLine($"{karakter1.Nev} nyerte a harcot!");
			}
		}
	}
}
