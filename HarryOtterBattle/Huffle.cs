using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class Hufflepuff : Ingredients2
    {
        public Hufflepuff(string fileName)
            :base()
        {
            Load(fileName);
        }
    }
}
