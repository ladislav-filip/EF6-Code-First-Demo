﻿using System.Collections.Generic;

namespace EF6CodeFirstDemo
{
    public class Obv
    {
        public string Typ { get; set; }
        public int Rok { get; set; }
        public int Cislo { get; set; }

        public string Popis { get; set; }

        public ICollection<ObvItem> Items { get; set; }
    }
}