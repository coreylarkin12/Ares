using Capstone.DAL;
using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capstone
{
    public class CapstoneCLI
    {
        /// <summary>
        /// These are the const we use in our case statements that correspond with the menu we created 
        /// we created a type string for each const and also added our database connection here as well
        /// even though we could have done that in the main program 
        /// </summary>
        const string DatabaseConnection = @"Data Source = localhost\sqlexpress;Initial Catalog = NationalPark; Integrated Security = True";
        const string Command_AllParks = "1";
        const string Command_AllCampgrounds = "2";
        const string Command_SelectCampsite = "3";
        const string Command_MakeReservation = "4";
        const string Command_Quit = "q";
        /// <summary>
        /// The RunCLI is called to the main program and contains the main menu and all the request for user to input information
        /// </summary>
        public void RunCLI()
        {
            PrintMenu();
            
            while (true)
            {
                string command = Console.ReadLine();

                
                //These case staements are used to call the methods from below based off the number entered in by the user

                switch (command.ToLower())
                {
                    case Command_AllParks:
                        GetAllParks();
                        break;
                    case Command_AllCampgrounds:
                        GetAllCampgrounds();
                        break;
                    case Command_SelectCampsite:
                        SearchCampSites();
                        break;
                    case Command_MakeReservation:
                        MakeAreservation();
                        break;
                    case Command_Quit:
                        Console.WriteLine("Thank you for using our application!");
                        return;                     
                }
                PrintMenu();
            }
        }
        /// <summary>
        /// Get all Parks calls the GetParks method from the ParkSqlDAL Class and creates a list
        /// then that list is called into an if statement and if the count of the items in the list is > 0
        /// then it will print out all the parks contained in the park table in the database
        /// else no results will be printed out.
        /// </summary>
        private void GetAllParks()
        {
            ParkSqlDAL dal = new ParkSqlDAL(DatabaseConnection);
            List<Park> parks = dal.GetParks();

            if(parks.Count > 0)
            {                           //I used a lambda expression in the foreach loop. Just a different way to write the foreach loop
                                        //But does exactly the same thing if written out the longer way.
                parks.ForEach(item =>
                {
                    Console.WriteLine(item + "\n");
                });
            }
            else
            {
                Console.WriteLine("NO RESULTS");
            }
        }
        /// <summary>
        /// GetAllCampgrounds calls the GetCampgrounds method from the campgroundSqlDAL it creates a list and calls that list
        /// into a if statement. it uses the cli helper to take in user input like a readline would
        /// it the GetCampgrounds method takes in a parameter of type int parkID so we created myParkID
        /// which is the number the user enters and then put that into the list.
        /// If the count in the list is > 0 it prints out all the campground information to the console screen
        /// we added a console writeline for formatting purposes so the user new what each column represented. 
        /// </summary>
        private void GetAllCampgrounds()
        {
            int myParkid = CLIHelper.GetInteger("Please enter the Park ID (1 (Acadia) , 2 (Arches) or 3 (Cuyahoga National Valley Park): ");
            CampgroundSqlDAL dal = new CampgroundSqlDAL(DatabaseConnection);
            List<Campground> campgrounds = dal.GetCampgrounds(myParkid);

            if(campgrounds.Count > 0)
            {
                Console.WriteLine("".PadRight(10) +"Name".PadRight(35) + "Open".PadRight(20) + "Close".PadRight(20) + "Daily Fee".PadRight(20));
                campgrounds.ForEach(thing =>
                {
                    
                    Console.WriteLine(thing);
                });
            }
            else
            {
                Console.WriteLine("NO RESULTS");
            }
        }
        /// <summary>
        /// SearchCampSites method calls the GetSites method from the SiteSqlDAL and pass it to a list which we then call in the if statement 
        /// and if count > 0 we then print out the appropriate response and we again use the foreach loop to print out the results from the
        /// database. we also use the CLIhelper again to take in the user input. 
        /// </summary>
        private void SearchCampSites()
        {
            int campgroundId = CLIHelper.GetInteger("Which campground (enter 0 to cancel)? ");
            DateTime startDate = CLIHelper.GetDateTime("What is the arrival date? (YYYY/MM/DD): ");
            DateTime endDate = CLIHelper.GetDateTime("What is the departure date? (YYYY/MM/DD): ");

            //double totalDays = (endDate - startDate).TotalDays;

            SiteSqlDAL dal = new SiteSqlDAL(DatabaseConnection);
            List<Site> allSites = dal.GetSites(campgroundId, startDate, endDate);

            if(allSites.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Site Number".PadRight(14) + "Max Occupancy".PadRight(15) + "Accessible".PadRight(15) + "Max RV Length".PadRight(17) + "Utilities".PadRight(16) + "Cost".PadRight(15));
                Console.WriteLine();

                allSites.ForEach(theseSites =>
                {
                    Console.WriteLine(theseSites);
                });
            }
            else
            {
                Console.WriteLine("There was an error with your inputs...");
            }
        }
        /// <summary>
        /// In the makeAreservation method we again use the cli helper to take in user input. 
        /// It calls the MakeReservation method from the ReservationSqlDAL class and uses it in a list
        /// We created variables of type string in and dateTime to store the user input then we called the reservation class
        /// from the models folder and assigned the user input to the variables in the reservation class which are get; set; properties
        /// We then call the list in a  if statement again and if count of items in list is > 0 we then print out the response with the 
        /// reservation id confirming their reservation has been created. 
        /// </summary>
        private void MakeAreservation()
        {
            string name = CLIHelper.GetString("Please enter the reservation name: ");
            int site_id = CLIHelper.GetInteger("Please enter the site number: ");
            DateTime startDate = CLIHelper.GetDateTime("Please enter the arrival date(YYYY/MM/DD): ");
            DateTime endDate = CLIHelper.GetDateTime("Please enter the departure date(YYYY/MM/DD): ");
            

            Reservation newRes = new Reservation()
            {
                Name = name,
                SiteID = site_id,
                FromDate = startDate,
                ToDate = endDate,
                CreateDate = DateTime.Now
                
            };

            ReservationSqlDAL dal = new ReservationSqlDAL(DatabaseConnection);
            List<Reservation> confirm = dal.MakeReservation(newRes);

            if (confirm.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("The reservation has been made and the confirmation ID is: " + confirm[0].ReservationId );
            }
            else
            {
                Console.WriteLine("DID NOT MAKE RESERVATION");
            }
        }
        /// <summary>
        /// This is the PrintMenu method and we use it to design the main menu and what we would like it to display and we call this at the 
        /// top of the RunCli method and after the case statements so the user always has access to this menu and its selections
        /// </summary>
        private void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Main Menu Please type in a command");
            Console.WriteLine(" 1 - Show all Parks");
            Console.WriteLine(" 2 - Show all Campgrounds");
            Console.WriteLine(" 3 - Select a Campsite");
            Console.WriteLine(" 4 - Make a Reservation");
            Console.WriteLine(" Q - Exit Application");
            Console.WriteLine();
        }

    }
}
