﻿using System;

namespace Classes1
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessTrip[] businessTrips =
            {
                new BusinessTrip("Alexandr Alexandrov", 2301, 3),
                new BusinessTrip("Petr Petrov", 1168, 4),
                null,
                new BusinessTrip("Ivan Ivanov", 2301, 5),
                new BusinessTrip()
            };

            foreach (BusinessTrip trip in businessTrips)
            {
                if (trip != null)
                {
                    trip.Show();
                }
            }

            if (businessTrips[businessTrips.Length - 1] != null)
            {
                businessTrips[businessTrips.Length - 1].TransportationExpenses = 1365;
            }

            Console.WriteLine("Duration = " + (businessTrips[0].Days + businessTrips[1].Days));

            foreach (BusinessTrip trip in businessTrips)
            {
                Console.WriteLine(trip);
            }
        }
    }
}