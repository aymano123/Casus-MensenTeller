﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller
{
    class Vestiging
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Ruimte> Ruimtes { get; set; }

        public Locatie Locatie { get; set; }





        public Vestiging()
        {
        }


        public Vestiging(int id)
        {
            Id = id;
        }

        public Vestiging(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Vestiging(int id, string name, List<Ruimte> ruimtes, Locatie locatie)
        {
            Id = id;
            Name = name;
            Locatie = locatie;
            Ruimtes = ruimtes;
        }

    }

}
