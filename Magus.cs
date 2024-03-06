using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterkezeles
{
	internal class Magus : Karakter
	{
		public int Mana;
		public Magus(string nev, int ero, int eletero, int mana = 50) : base(nev, ero, 10, eletero) 
		{
			this.Mana = mana;
		}
		public override void Gyogyul()
		{
			base.Gyogyul();
			Eletero += 5;
			Mana -= 5;
		}
		public override int Tamad()
		{
			return base.Tamad();
		}
	}
}
