using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class Galleon_of_Water : Ingredients2
    {
        public Galleon_of_Water(string fileName)
            : base()
        {
            Load(fileName);
        }
    }
}
