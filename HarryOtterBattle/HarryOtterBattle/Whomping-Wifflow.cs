using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class Whomping_Wifflow : Ingredients2
    {
        public Whomping_Wifflow(string fileName)
            :base()
        {
            Load(fileName);
        }
    }
}
