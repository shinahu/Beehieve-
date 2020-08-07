using System;
using System.Collections.Generic;

namespace Beehives
{
    class Program
    {
        static void Main(string[] args)
        {

            Bees bees1 = new Bees();
            Bees bees2 = new Bees("John", 3.2f);
            Bees bees3 = new Bees("Paul", 2.7f);
            Bees bees4 = new Bees("George", 1.1f);
            Bees bees5 = new Bees("Ringo", 2.0f);
            Bees bees6 = new Bees("Kurt", 2.3f);
            Bees bees7 = new Bees("Dave", 7.4f);
            Bees bees8 = new Bees("Krist", 1.5f);

            Beehive bh1 = new Beehive();
            bh1.AddBees(bees2);
            bh1.AddBees(bees3);
            bh1.AddBees(bees4);
            bh1.AddBees(bees5);


            Beehive bh2 = new Beehive();
            bh2.AddBees(bees6);
            bh2.AddBees(bees7);
            bh2.AddBees(bees8);


            System.Console.WriteLine("The beehive that Collected the Most Honey is?");
     
            System.Console.WriteLine("Beehieve 1");
            bh1.CollectHoney(10);

            System.Console.WriteLine("Beehieve 2");
     
            bh2.CollectHoney(10);



        }
    }
}



