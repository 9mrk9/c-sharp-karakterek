using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterkezeles
{
	internal class Harcos : Karakter
	{
		public int Pancel;
		public Harcos(string nev, int ero, int eletero, int pancel) : base(nev, ero + 5, 3, eletero)
		{
			this.Pancel = pancel;
		}
		public override int Vedekezik()
		{
			return base.Vedekezik() + Pancel;
		}
	}
}