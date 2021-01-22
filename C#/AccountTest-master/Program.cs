using System;

namespace AccountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an account object and assign it to myAccount
            Account myAccount = new Account();

            if(myAccount.GetName() == null)
            {
                //Prompt for and read the name, then put the name in the object
                Console.WriteLine("Enter the name:"); //prompt

                string theName = Console.ReadLine(); // read the name

                myAccount.SetName(theName); //put theName in my Account

            }
            else
            {
                Console.WriteLine($"This account belongs to: {myAccount.GetName()}");
            }
            //Display myAccount's initial name (there isn't one)
            Console.WriteLine($"This account belongs to: {myAccount.GetName()}");

            
            // display the name stored in the myAcoount object 
            Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
            
        }
    }
}
