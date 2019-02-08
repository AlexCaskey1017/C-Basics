using System;
namespace Csharp_Basics
{
    public class Csharp_Basics
    {

        public Csharp_Basics()
        {
            const byte Sample1 = 0x3A;
            byte Sample2 = 58;
            int heartRate = 85;
            double deposites = 135002796;
            float accelertion = 9.800F;
            float mass = 14.6F;
            double distance = 129.763001;
            bool lost = true;
            bool expense = true;
            int choice = 2;
            char integral = '\u222B';
            const string greeting = "hello";
            string name = "karen";
            int i = 0;
            int age = 0;

            /*comparing Sample1 to Sample2*/

            if (Sample1 == Sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }

            /*heart rate check*/

            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            } 
            else
            {
            Console.WriteLine("Heart rate is not normal.");
            }

            /*bank statement*/

            if (deposites >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }
            /*calculating force*/

            double force = mass * accelertion;
            Console.WriteLine(force);

            /*display the distance*/

            Console.WriteLine(distance.ToString(), " Is the distance");

            /*coupon boolean*/

            if (lost == true && expense == true)
            {
                Console.WriteLine("I am really sorry!I will get the manager.");
            } else if (lost == true && expense == false)
            {
                Console.WriteLine("Here is coupon for 10 % off.");
            } else
            {
                Console.WriteLine("");
            }

                /* switch/case */

                switch (choice) 
                {

                    case 1:
                        Console.WriteLine("You chose 1.");
                        break;
                    case 2:
                        Console.WriteLine("You chose 2.");
                        break;
                    case 3:
                        Console.WriteLine("You chose 3.");
                        break;
                    default:
                        Console.WriteLine("You made an unknown choice.");
                        break;
                }
            /* display integral */

            Console.WriteLine(integral.ToString() , " Is an integral.");

                /* for loop */

                for (i = 5; i < 11; i++)
                {
                    Console.WriteLine("Value of i: " + i.ToString());
                }

            /* While loop */

            while (age < 7)
            {           
                Console.WriteLine("Value of age: {0}", age);
                age++;
            }

            /* greeting + name */

            Console.WriteLine(greeting, name);

        }
    }
}
