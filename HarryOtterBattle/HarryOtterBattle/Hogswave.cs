using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class Hogswave : Ingredients2
    {
        public Hogswave(string fileName)
            :base()
        {
            Load(fileName);
        }
    }
}
