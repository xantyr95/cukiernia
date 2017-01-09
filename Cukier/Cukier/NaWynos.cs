using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cukier
{
    class NaWynos : Zamowienie
    {
        public override bool PoprawnyCzas()
        {
            if (czasDostawy.Hour > (Convert.ToInt32(DateTime.Today.Hour) + 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}