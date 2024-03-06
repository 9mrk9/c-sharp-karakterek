using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterkezeles
{
	class Program
	{
		static void Main(string[] args)
		{
			Ijasz Legolas = new Ijasz("Legolas", 8, 80);
			Magus Potter = new Magus("Potter", 5, 90);
			Harcos Kratos = new Harcos("Kratos", 7, 100, 5);
			Pankrator John = new Pankrator("John", 6, 110);
			KarakterLista Karakterek = new KarakterLista();

			Karakterek.KarakterHozzaAd(Legolas);
			Karakterek.KarakterHozzaAd(Potter);
			Karakterek.KarakterHozzaAd(Kratos);
			Karakterek.KarakterHozzaAd(John);

			Karakterek.KarakterListaz();

			Harc.KarakterHarc(Kratos, John);
			Console.ReadKey();
		}
	}
}
