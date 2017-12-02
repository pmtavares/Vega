using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.Model
{
    public class Make
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Modell> Models { get; set; }

        public Make()
        {
            Models = new Collection<Modell>(); //Just serialize and return to the client
        }
    }
}
