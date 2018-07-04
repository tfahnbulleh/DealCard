using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeal
{
    class Card
    {

        public Card(string face, string suite)
        {
            this.Face = face;
            this.Suite = suite;
        }

        public String Face { get; set; }
        public String Suite { get; set; }

        public override string ToString()
        {
            return this.Suite + " " + this.Face;
        }
    }
}
