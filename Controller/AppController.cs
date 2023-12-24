using VendingMachine.Model;
using VendingMachine.Model.Items;

namespace VendingMachine.Controller
{
    /// <summary>
    /// Controller to manage view and model 
    /// </summary>
    public class AppController : IController
    {
        private List<IItem> items;

        private static Money money;

        private ProductTracker productTracker;

        public AppController() 
        {
            items = new List<IItem>();
            money = Money.GetInstance();
            productTracker = new ProductTracker(0, 0, 0, 0);
        }

        public void AddItem(IItem item)
        {
            items.Add(item);
            productTracker.Increment(item.id);
        }

        public void RemoveItems(IItem item)
        {
            items.Remove(item);
            productTracker.Decrement(item.id);
        }

        public List<string> GetAllItems()
        {
            List<string> available = ["Pepsi ", "Coke ", "Soda ", "Chips "];

            return available;
        }

        public void GetItem(int v)
        {
            switch(v) 
            { 
                case 1: // Pepsi
                    if(productTracker.CheckIfAvailable(1))
                    {
                        Pepsi item = items.Find(it => it.GetType() == typeof(Pepsi)) as Pepsi;
                        RemoveItems(item);
                        money.AddMoney(item.Price);
                        ReceiptHandler.PrintReceipt("Here is you pepsi !!!");
                    }
                    else
                    {
                        ReceiptHandler.PrintReceipt("Sorry Pepsi not available at this time");
                    }
                    break;

                case 2: // Coke
                    if (productTracker.CheckIfAvailable(2))
                    {
                        Coke item = items.Find(it => it.GetType() == typeof(Coke)) as Coke;
                        RemoveItems(item);
                        money.AddMoney(item.Price);
                        ReceiptHandler.PrintReceipt("Here is you Coke !!!");
                    }
                    else
                    {
                        ReceiptHandler.PrintReceipt("Sorry Coke not available at this time");
                    }
                    break;

                case 3: // Soda
                    if (productTracker.CheckIfAvailable(1))
                    {
                        Soda item = items.Find(it => it.GetType() == typeof(Soda)) as Soda;
                        RemoveItems(item);
                        money.AddMoney(item.Price);
                        ReceiptHandler.PrintReceipt("Here is you Soda !!!");
                    }
                    else
                    {
                        ReceiptHandler.PrintReceipt("Sorry Soda not available at this time");
                    }
                    break;

                case 4: // Chips
                    if (productTracker.CheckIfAvailable(1))
                    {
                        Chips item = items.Find(it => it.GetType() == typeof(Chips)) as Chips;
                        RemoveItems(item);
                        money.AddMoney(item.Price);
                        ReceiptHandler.PrintReceipt("Here is you Chips !!!");
                    }
                    else
                    {
                        ReceiptHandler.PrintReceipt("Sorry Chips not available at this time");
                    }
                    break;
            }
        }
    }
}
