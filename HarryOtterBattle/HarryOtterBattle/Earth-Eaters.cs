using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class Earth_Eaters : Ingredients2
    {
        public Earth_Eaters(string fileName)
            : base()
        {
            Load(fileName);
        }
    }
}
