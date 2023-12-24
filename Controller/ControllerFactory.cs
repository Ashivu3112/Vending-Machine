
namespace VendingMachine.Controller
{
    /// <summary>
    /// Controller factory to create all the objects for controller
    /// </summary>
    public class ControllerFactory
    {
        public ControllerFactory() { 
        }

        public AppController GetController()
        {
            return new AppController();
        }
    }
}
