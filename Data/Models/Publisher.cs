﻿using System.Collections.Generic;

namespace Libreriaa_NAGD.Data.Models
{
    public class Publisher
    {
        public string Id { get; set; }
        public string Name { get; set; }

        //Propiedades de navegacion
        public List<Books> Books { get; set; }
    }
}
