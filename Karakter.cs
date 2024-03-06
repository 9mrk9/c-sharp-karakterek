using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterkezeles
{
	class Karakter
	{
		public string Nev;
		public int Ero;
		public int Ugyesseg;
		public int Eletero { get => hp; set {
				hp = value;
				if (Eletero < 0)
				{
					Eletero = 0;
				}
			} }
		private int hp;

		public Karakter(string nev, int ero, int ugyesseg, int eletero)
		{
			this.Nev = nev;
			this.Ero = ero;
			this.Ugyesseg = ugyesseg;
			this.Eletero = eletero;
		}

		
		public void KarakterInfo()
		{
			Console.WriteLine($"A karaktered neve: {Nev}\nA karaktered erőszintje: {Ero}\nA karaktered ugyessége: {Ugyesseg}\nA karaktered életereje: {Eletero}\n\n");
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