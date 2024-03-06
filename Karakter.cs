using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterkezeles
{
	internal class Karakter
	{
		public string Nev;
		public int Ero;
		public int Ugyesseg;
		public int Eletero;

		public Karakter(string nev, int ero, int ugyesseg, int eletero)
		{
			this.Nev = nev;
			this.Ero = ero;
			this.Ugyesseg = ugyesseg;
			this.Eletero = eletero;
		}
		public void KarakterInfo()
		{
            Console.WriteLine($"A karaktered neve: {Nev}\nA karaktered erőszintje: {Ero}\nA karaktered ugyessége: {Ugyesseg}\nA karaktered életereje: {Eletero}");
        }
		public virtual int Tamad()
		{
			return Ero + Ugyesseg;
		}
		public virtual int Vedekezik()
		{
			return 0;
		}
		public virtual void Gyogyul()
		{
			Eletero += 10;
		}
	}
}
