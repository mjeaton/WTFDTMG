using System;
using System.Collections.Generic;
using System.Linq;
using Massive;

namespace WTFDTMG.Models
{
    public class Account : DynamicModel, IAccount
    {
        public Account() : base("connString", "account", "id")
        {

        }

        public string Name { get; set; }
    }
}