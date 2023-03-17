using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manimani
{
    internal class notes
    {
        public string name { get; set; }
        public string type { get; set; }
        public string money { get; set; }
        public bool isIncome { get; set; }

        public notes(string name, string type, string money, bool isIncome)
        {
            this.name = name;
            this.type = type;
            this.money = money;
            this.isIncome = isIncome;
        }

    }
}
