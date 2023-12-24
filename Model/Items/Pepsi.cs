

namespace VendingMachine.Model.Items
{
    /// <summary>
    /// Pepsi class
    /// </summary>
    public class Pepsi : IItem
    {
        public int id {  get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public Pepsi(int id, string name, string des, int price)
        {
            this.id = id;
            Name = name;
            Description = des;
            Price = price;
        }
    }
}
