using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class Muckle : Ingredients2
    {
        public Muckle(string fileName)
            :base()
        {
            Load(fileName);
        }
    }
}
