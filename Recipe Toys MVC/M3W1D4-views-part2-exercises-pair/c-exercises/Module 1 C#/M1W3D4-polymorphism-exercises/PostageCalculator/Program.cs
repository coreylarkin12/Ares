using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<IDeliveryDriver> delivery = new List<IDeliveryDriver>();

            delivery.Add(new _1stClass());
            delivery.Add(new _2ndClass());
            delivery.Add(new _3rdClass());
            delivery.Add(new FexEd());
            delivery.Add(new SPU());
            delivery.Add(new SPUTwo());
            delivery.Add(new SPUNext());


            double finalRate = 0;

            Console.WriteLine("Please enter the weight of the package? ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("(P)ounds or (O)unces? ");
            string poundsOunces = Console.ReadLine();

            Console.WriteLine("What distance will it be traveling to? ");
            int distance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Delivery Method                 $ cost");
            Console.WriteLine("--------------------------------------");
            bool fourDayGround = true;
            bool twoDayBusiness = true;
            foreach (IDeliveryDriver delvieryClass in delivery)
            {
                double rate = delvieryClass.CalculateRate(distance, weight);
                finalRate += rate;
                if(delvieryClass is _1stClass)
                {
                    Console.WriteLine("Postal Service (1stClass)        " + "$" + delvieryClass.CalculateRate(distance, weight));
                }
                else if (delvieryClass is _2ndClass)
                {
                    Console.WriteLine("Postal Service (2ndClass)        " + "$" + delvieryClass.CalculateRate(distance, weight));
                }
                else if (delvieryClass is _3rdClass)
                {
                    Console.WriteLine("Postal Service (3rdClass)        " + "$" + delvieryClass.CalculateRate(distance, weight));
                }
                else if (delvieryClass is FexEd)
                {
                    Console.WriteLine("FexEd                            " + "$" + delvieryClass.CalculateRate(distance, weight));
                }
                else if(delvieryClass is SPU && fourDayGround == true)
                {
                    Console.WriteLine("SPU (4-Day Ground)               " + "$" + delvieryClass.CalculateRate(distance, weight));
                }
                else if(delvieryClass is SPUTwo && twoDayBusiness == true)
                {
                    Console.WriteLine("SPU (2-Day Business)             " + "$" + delvieryClass.CalculateRate(distance, weight));
                }
                else
                {
                    Console.WriteLine("SPU (Next-Day)                   " + "$"+ delvieryClass.CalculateRate(distance, weight));
                }
                
                
            }
           


            Console.Read();
        }
    }
}
