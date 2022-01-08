using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class Dirt_lord : Ingredients2
    {
        public Dirt_lord(string fileName)
            :base()
        {
            Load(fileName);
        }
    }
}
