using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P033_Classes_Objects
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balancce { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }


    }
}
