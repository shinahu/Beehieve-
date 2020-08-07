using System.Collections.Generic;

namespace Beehives
{
    public class Beehive
    
    {
        // attributes / variables
        public List<Bees> bees;
        public int maxAmountofBees = 4;
        public Beehive()
        {
          this.bees = new List<Bees>();
          this.maxAmountofBees = 4;

        }

        public void AddBees(Bees newBee)
        {
            if (bees.Count >= this.maxAmountofBees)
            {
               System.Console.WriteLine("The maximum amount of bees in the Hive reached");
            } else 
            this.bees.Add(newBee);
        } 
       
        public void CollectHoney (int days) 
        {
           foreach (Bees x in this.bees)
           {
             float Amount = days * x.Size * 0.2f;

             System.Console.WriteLine("The Honey collected by " + x.Name + " is; " + Amount);
           }
        }

    }
}