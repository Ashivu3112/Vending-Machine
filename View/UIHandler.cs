
using VendingMachine.Controller;

namespace VendingMachine.View
{
    /// <summary>
    /// Class that handles UI related functionality
    /// </summary>
    public class UIHandler
    {
        private AppController controller;

        public UIHandler(AppController controller) 
        {
            this.controller = controller;
        }

        public void RunProcess()
        {
            Console.WriteLine("Hello! Please enter a choice from below: ");
            List<string> items = controller.GetAllItems();
            int i = 1;
            foreach (string item in items) 
            {
                Console.WriteLine("{0}: {1}" ,i , item);
                i++;
            }
            GetInput();
        }

        public void GetInput()
        {
            Console.Write("Input: ");
            string? input = Console.ReadLine();

            switch (Convert.ToInt32(input))
            {
                case 1:
                    controller.GetItem(1);
                    break;
                case 2:
                    controller.GetItem(2);
                    break;
                case 3:
                    controller.GetItem(3);
                    break;
                case 4:
                    controller.GetItem(4);
                    break;
                default:
                    Console.WriteLine("Please enter correct input...");
                    Program.continueOperation = false;
                    break;
            }
        }
    }
}
