

namespace VendingMachine.Model
{
    /// <summary>
    /// Tracker to keep a tracker of all items
    /// </summary>
    public class ProductTracker
    {
        int PepsiItems; 
        int CokeItems; 
        int SodaItems; 
        int ChipsItems; 

        public ProductTracker (int pep, int coke, int soda, int chips) 
        {
            PepsiItems = pep;
            CokeItems = coke;
            SodaItems = soda;
            ChipsItems = chips;    
        }

        public bool CheckIfAvailable(int id)
        {
            switch(id)
            {
                case 1:
                    if(PepsiItems > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 2:
                    if (CokeItems > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 3:
                    if (SodaItems > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 4:
                    if (ChipsItems > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }

            return false;
        }

        public void Increment(int id)
        {
            switch (id)
            {
                case 1:
                    PepsiItems++;
                    break;
                case 2:
                    CokeItems++;
                    break;
                case 3:
                    SodaItems++;
                    break;
                case 4:
                    ChipsItems++;
                    break;
            }
        }

        public void Decrement(int id)
        {
            switch (id)
            {
                case 1:
                    PepsiItems--;
                    break;
                case 2:
                    CokeItems--;
                    break;
                case 3:
                    SodaItems--;
                    break;
                case 4:
                    ChipsItems--;
                    break;
            }
        }
    }
}
