using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterkezeles
{
	internal class Pankrator : Karakter
	{
		public Pankrator(string nev, int ero, int eletero) : base(nev, ero + 5, 5, eletero)
		{
		}
		public override int Tamad()
		{
			return base.Tamad() + 3;
		}
	}
}