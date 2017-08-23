using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Capstone.Classes
{
    public class VendingMachine 
    {
        private Dictionary<string, VendingMachineItem> allItems = new Dictionary<string, VendingMachineItem>();
        private double balance;

        public VendingMachine()
        {
            
            string directory = Environment.CurrentDirectory; 
            string fileName = "vendingmachine.csv";
            string fullPath = Path.Combine(directory, fileName);


            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {

                        string line = sr.ReadLine();
                        string[] arrayItems = line.Split('|');
                        allItems.Add(arrayItems[0], new VendingMachineItem(arrayItems[1], Convert.ToDouble(arrayItems[2])));
                        
                    }


                }
            }
            catch(Exception)
            {
                Console.WriteLine("There is no pricing file in the current directory.");
                Console.WriteLine();
                
                
            }

        }

        public Dictionary<string, VendingMachineItem> AllItems
        {
            get
            {
                return allItems;
            }
            set
            {
                allItems = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public void FeedMoney(int dollarAmount)
        {
            balance += dollarAmount;
            UpdateLog("FEED MONEY:", dollarAmount);
        }
        public int SelectProduct(string productID)
        {
            productID = productID.ToUpper();
            if (allItems.ContainsKey(productID))
            {
                if (allItems[productID].Quantity > 0)
                {
                    if(balance >= allItems[productID].Price)
                    {
                        double startingBalance = Balance;
                        balance -= allItems[productID].Price;
                        allItems[productID].Quantity--;
                        UpdateLog(String.Concat(allItems[productID].Name," ", productID), startingBalance);
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
            
        }
        public int[] MakeChange()    //Dispenses change in smallest number of coins possible 
        {
            double startingBalance = Balance;
            int[] change = new int[3];
            double remainder = balance % 0.25;
            change[0] = (int)((balance - remainder) / 0.25);
            balance = remainder;
            remainder = balance % 0.10;
            change[1] = (int)((balance - remainder) / 0.10);
            balance = 0;
            
            if(remainder > 0.001)
            {
                change[2] = 1;
            }
            else
            {
                change[2] = 0;
            }
            UpdateLog("GIVE CHANGE:", startingBalance);
            return change;

        }
        public void UpdateLog(string function, double dollar)
        {
            try
            {
                string directory = Environment.CurrentDirectory;
                string fileName = "Audit-Log.txt";
                string fullPath = Path.Combine(directory, fileName);

                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                   
                    sw.WriteLine("{0} {1, -20} ${2, -10:0.00} ${3, -10:0.00}", DateTime.Now, function, dollar, Balance);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry there was an error.");
                Console.ReadLine();
            }
        }
        public void SalesReport()
        {
            try
            {
                string currentTime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                string directory = Environment.CurrentDirectory;
                string fileName = $"SalesReport{currentTime}.txt";
                string fullPath = Path.Combine(directory, fileName);

                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    double totalSales = 0;
                    foreach(KeyValuePair<string, VendingMachineItem> item in AllItems)
                    {
                        int count;
                        using (StreamReader sr = new StreamReader(Path.Combine(directory, "Audit-Log.txt")))
                        {
                            count = 0;
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                if (line.Contains(item.Key))
                                {
                                    count++;
                                }
                            }
                        }
                        sw.WriteLine("{0}|{1}", item.Value.Name, count);
                        totalSales += count * item.Value.Price;
                    }
                    sw.WriteLine();
                    sw.WriteLine("**TOTAL SALES** ${0:0.00}", totalSales);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Sorry there was an error.");
                Console.ReadLine();
            }
        }
    }
}
