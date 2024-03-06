using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterkezeles
{
	internal class Ijasz : Karakter
	{
		public Ijasz(string nev, int ero, int eletero) : base(nev, ero, 7, eletero)
		{

		}
		public override int Vedekezik()
		{
			if (new Random().Next(1, 5) == 2)
			{
				return int.MaxValue;
			}
			else
			{
				return base.Vedekezik();
			}
		}
	}
}