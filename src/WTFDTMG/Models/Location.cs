using System;
using System.Collections.Generic;
using System.Linq;
using Massive;

namespace WTFDTMG.Models
{
    public class Location : DynamicModel, ILocation
    {
        public Location() : base("connString", "Location", "Id") { }

        public string Name { get; set; }
    }
}
