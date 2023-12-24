using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine.Model.Items
{
    /// <summary>
    /// Coke class
    /// </summary>
    public class Coke : IItem
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public Coke(int id, string name, string des, int price) {
            this.id = id;
            Name = name;
            Description = des;
            Price = price;
        }
    }
}
