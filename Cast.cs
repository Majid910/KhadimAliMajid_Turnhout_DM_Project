using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConnector
{
    public class Cast : Person
    {
        public Cast(int id, string character, string name, string profilePath)
            : base(id, character, name, profilePath)
        {

        }

        public Cast(int id, string character, string name, byte[] image)
            : base(id, character, name, image)
        {

        }
    }
}
