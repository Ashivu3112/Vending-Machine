
namespace VendingMachine.Model
{
    /// <summary>
    /// Singleton class to handle Money related functionality
    /// </summary>
    public class Money
    {
        private int TotalMoney;
        private static Money MoneyInstance { get; set; }

        public int GetTotalMoney { get { return TotalMoney; } }

        private Money(int totalMoney)
        {
            TotalMoney = totalMoney;
        }

        public static Money GetInstance()
        {
            if (MoneyInstance == null)
            {
                MoneyInstance = new Money(0);
                return MoneyInstance;
            }
            else
            {
                return MoneyInstance;
            }
        }

        public void AddMoney(int addedMoney)
        {
            TotalMoney += addedMoney;
        }
    }
}
