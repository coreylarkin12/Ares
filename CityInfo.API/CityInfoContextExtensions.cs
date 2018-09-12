using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Entities;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // init seed data
            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "The most visited urban park in the united states"
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan."
                        },
                    }
                },
                new City()
                {
                    Name = "Columbus",
                    Description = "The best city in Ohio.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "The HorseShoe",
                            Description = "Where the Ohio State Buckeyes Play football on Saturday's."
                        },
                        new PointOfInterest()
                        {
                            Name = "German Village",
                            Description = "Old Historical village near downtown Columbus."
                        },
                    }
                },
                new City()
                {
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Eiffel Tower",
                            Description = "A wrought iron lattice tower on the Champ de Mars."
                        },
                        new PointOfInterest()
                        {
                            Name = "The Louvre",
                            Description = "The worlds largest museum."
                        },
                    }
                }
            };


            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
