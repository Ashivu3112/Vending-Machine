
using VendingMachine.Controller;
using VendingMachine.Model.Items;
using VendingMachine.View;

public class Program
{
    public static bool continueOperation = true;
    public static void Main()
    {
        ControllerFactory factory = new ControllerFactory();
        AppController controller = factory.GetController();

        UIHandler UIhandler = new UIHandler(controller);

        #region Add items
        IItem item = new Pepsi(1, "Pepsi", "Made in India", 40);
        controller.AddItem(item);

        item = new Pepsi(1, "Pepsi", "Made in India", 40);
        controller.AddItem(item);

        item = new Pepsi(1, "Pepsi", "Made in India", 40);
        controller.AddItem(item);

        item = new Pepsi(1, "Pepsi", "Made in India", 40);
        controller.AddItem(item);

        item = new Coke(2, "Coke", "Made in India", 30);
        controller.AddItem(item);

        item = new Coke(2, "Coke", "Made in India", 30);
        controller.AddItem(item);

        item = new Coke(2, "Coke", "Made in India", 30);
        controller.AddItem(item);

        item = new Coke(2, "Coke", "Made in India", 30);
        controller.AddItem(item);

        item = new Coke(2, "Coke", "Made in India", 30);
        controller.AddItem(item);

        item = new Soda(3, "Soda", "Made in India", 25);
        controller.AddItem(item);

        item = new Soda(3, "Soda", "Made in India", 25);
        controller.AddItem(item);

        item = new Soda(3, "Soda", "Made in India", 25);
        controller.AddItem(item);

        item = new Soda(3, "Soda", "Made in India", 25);
        controller.AddItem(item);

        item = new Soda(3, "Soda", "Made in India", 25);
        controller.AddItem(item);

        item = new Soda(3, "Soda", "Made in India", 25);
        controller.AddItem(item);

        item = new Chips(4, "Chips", "Made in India", 10);
        controller.AddItem(item);

        item = new Chips(4, "Chips", "Made in India", 10);
        controller.AddItem(item);

        item = new Chips(4, "Chips", "Made in India", 10);
        controller.AddItem(item);
        #endregion

        while (continueOperation)
        {
            UIhandler.RunProcess();
        }
    }
}