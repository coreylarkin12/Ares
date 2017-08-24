using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfAxles = 0;
            bool hasTrailer = true;
            string tank = "";

            List<IVehicle> vehicle = new List<IVehicle>();          //list to call too.

            vehicle.Add(new Car(hasTrailer));
            vehicle.Add(new Truck(numberOfAxles));
            vehicle.Add(new Tank(tank));

            

            Random randomNum = new Random();
            

            Console.WriteLine("{0, -20} {1,-20} {2, -20}", "Vehicle", "Distance Traveled", "Toll $");   //first output lines formatted

            double totalRevenue = 0;
            double totalMiles = 0;
        
            foreach(IVehicle newVehicles in vehicle)                        //foreach loop doing calculations 
            {

                
                int distance = randomNum.Next(10, 240);
                double pay = newVehicles.CalculateToll(distance);
                totalMiles += distance;
                totalRevenue += pay;                                        //vehicle output is broken 
                if (newVehicles is Car)
                {
                    Console.WriteLine("{0,-20} {1,-20} ${2,-20: 0.00}", $"Car", distance, totalRevenue);
                }
                else if(newVehicles is Truck)
                {
                    Console.WriteLine("{0,-20} {1,-20} ${2,-20: 0.00}", $"Truck", distance, totalRevenue);
                }
                else if(newVehicles is Tank)
                {
                    Console.WriteLine("{0,-20} {1,-20} ${2,-20: 0.00}", $"Tank", distance, pay);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Total Miles Traveled: " + totalMiles);
            Console.WriteLine("{0,0} ${1:0.00}", "Total Tollbooth Revenue: ", totalRevenue);        //total revenue is broken 

            Console.Read();
        }
    }
}
