using System;

namespace VendingMachine.Model.Items
{
    /// <summary>
    /// Chips class
    /// </summary>
    public class Chips : IItem
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public Chips(int id, string name, string des, int price)
        {
            this.id = id;
            Name = name;
            Description = des;
            Price = price;
        }
    }
}
