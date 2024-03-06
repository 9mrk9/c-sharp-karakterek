using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterkezeles
{
	internal class KarakterLista
	{
		public List<Karakter> Karakterek;

		public void KarakterHozzaAd(Karakter karakter)
		{
			Karakterek.Add(karakter);
		}
		public void KarakterListaz()
		{
            foreach (Karakter karakter in Karakterek)
            {
                karakter.KarakterInfo();
            }
        }
	}
}
