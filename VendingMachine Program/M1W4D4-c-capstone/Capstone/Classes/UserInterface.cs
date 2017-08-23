using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class UserInterface
    {
        private VendingMachine VM;

        public UserInterface(VendingMachine VM)
        {
            this.VM = VM;
        }

        public void Run()
        {
            bool end = false;
            while (end == false)
            {
                int choice = RunMenu();
                if (choice == 1)
                {
                    DisplayVendingMachineItems();
                }
                else if (choice == 2)
                {
                    Purchase();
                }
                else if (choice == 3)
                {
                    SalesReport();
                }
                else if (choice == 4)
                {
                    end = Exit();
                }
            }
        }
        public int RunMenu()
        {
            bool end = false;
            int choice = 0;
            while (end == false)
            {
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine();
                Console.WriteLine("(2) Purchase");
                Console.WriteLine();
                Console.WriteLine("(3) Generate Sales Report");
                Console.WriteLine();
                Console.WriteLine("(4) Exit");
                Console.WriteLine();
                Console.Write("Please enter selection: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                }
                if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
                {
                    end = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please choose a valid selection (1-4)");
                    Console.WriteLine();
                }
            }
            return choice;
        }
        public void DisplayVendingMachineItems()
        {
            Console.Clear();
            Console.WriteLine("    {0,-20} {1,-10}  {2,-10}", "Item", "Price", "Remaining");
            Console.WriteLine();
            foreach (KeyValuePair<string, VendingMachineItem> product in VM.AllItems)
            {
                Console.WriteLine("{0}) {1,-20} ${2,-10:0.00}     {3}", product.Key, product.Value.Name, product.Value.Price, product.Value.Quantity);
            }
            Console.WriteLine();
            Console.Write("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public void Purchase()
        {
            bool end = false;
            while (end == false)
            {
                int choice = PurchaseMenu();
                if (choice == 1)
                {
                    Console.Clear();
                    FeedMoney();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    SelectProduct();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    end = FinishTransaction();
                }
            }
        }
        public int PurchaseMenu()
        {
            Console.Clear();
            bool end = false;
            int choice = 0;
            while (end == false)
            {
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine();
                Console.WriteLine("(2) Select Product");
                Console.WriteLine();
                Console.WriteLine("(3) Finish Transaction");
                Console.WriteLine();
                Console.WriteLine("Current Money Provided: ${0:0.00}", VM.Balance);
                Console.WriteLine();
                Console.Write("Please enter selection: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                }
                if (choice == 1 || choice == 2 || choice == 3)
                {
                    end = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please choose a valid selection (1-3)");
                    Console.WriteLine();
                }
            }
            return choice;
        }
        public void FeedMoney()
        {
            bool end = false;
            while (end == false)
            {
                int amountToAdd = 0;
                Console.Write("How much money would you like to add? ");
                try
                {
                    amountToAdd = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                }
                if (amountToAdd == 1 || amountToAdd == 2 || amountToAdd == 5 || amountToAdd == 10)
                {
                    end = true;
                    VM.FeedMoney(amountToAdd);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please choose a valid selection (1, 2, 5, 10)");
                    Console.WriteLine();
                }
            }
        }
        public void SelectProduct()
        {
            bool end = false;
            while (end == false)
            {
                Console.Write("Select an item to purchase: ");
                string product = Console.ReadLine();

                int result = VM.SelectProduct(product);

                if (result == -1)
                {
                    end = true;
                    Console.WriteLine();
                    Console.WriteLine("That is not a valid product.");
                    Console.WriteLine();
                    Console.Write("Please press enter to return to purchase screen.");
                    Console.ReadLine();
                }
                else if (result == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, this item is out of stock.");
                    Console.WriteLine();
                }
                else if (result == 2)
                {
                    end = true;
                    Console.Clear();
                    Console.WriteLine("Sorry, you do not have enough money.");
                    Console.WriteLine();
                    Console.Write("Please press enter to return to purchase screen.");
                    Console.ReadLine();
                }
                else
                {
                    end = true;
                    Console.WriteLine();
                    Console.WriteLine("Here is your item.");
                    Console.WriteLine();
                    if(product.ToUpper().Contains("A"))
                    {
                        Console.WriteLine("Crunch Crunch, Yum!");
                        Console.WriteLine();
                    }
                    else if (product.ToUpper().Contains("B"))
                    {
                        Console.WriteLine("Munch Munch, Yum!");
                        Console.WriteLine();
                    }
                    else if (product.ToUpper().Contains("C"))
                    {
                        Console.WriteLine("Glug Glug, Yum!");
                        Console.WriteLine();
                    }
                    else if (product.ToUpper().Contains("D"))
                    {
                        Console.WriteLine("Chew Chew, Yum!");
                        Console.WriteLine();
                    }
                    Console.Write("Please press enter to return to purchase screen.");
                    Console.ReadLine();
                }

            }
        }
        public bool FinishTransaction()
        {
            Console.Clear();
            int[] change = VM.MakeChange();
            Console.WriteLine("Thank you for shopping with us!");
            Console.WriteLine();
            Console.WriteLine("Your change is: {0} quarters, {1} dimes, and {2} nickels.", change[0], change[1], change[2]);
            Console.WriteLine();
            Console.Write("Press enter to return to the main menu.");
            Console.ReadLine();
            Console.Clear();
            return true;
        }
        public void SalesReport()
        {
            Console.Clear();
            VM.SalesReport();
            Console.WriteLine("Sales Report has been generated.");
            Console.WriteLine();
            Console.Write("Press Enter to return to main menu.");
            Console.ReadLine();
            Console.Clear();
        }
        public bool Exit()
        {
            Console.Clear();
            Console.WriteLine("Have a nice day!");
            Console.WriteLine();
            Console.Write("Press enter to exit.");
            Console.ReadLine();
            return true;
        }
    }
}
