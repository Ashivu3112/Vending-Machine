using System;


namespace VendingMachine.Model.Items
{
    /// <summary>
    /// Common interface for all items
    /// </summary>
    public interface IItem
    {
        int id { get;}
        string Name { get; }

        string Description { get; }

        int Price {  get; }

    }
}
