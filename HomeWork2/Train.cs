using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
   partial class Train
    {
        private int Number;
        private float Price;
        private string Destination;
        private string Departure;
        public float Time;
        private bool Express;
        public static double zone1;
        public static string sale = "15";

        //массив
        public string Name;
        public string Surname;
        public int Quantity_of_ticket;
        public int Age;
        public bool Baggage;

        public Train()
        {
            Name = Name;
            Surname = Surname;
            Quantity_of_ticket = Quantity_of_ticket;
            Age = Age;
            Baggage = Baggage;
        }

        public override string ToString()
        {
            return "Name: {0}\n Surname: {1}\n Quantity_of_ticket: {2}\n Age: {3}\n Baggage: {4}" + Name + Surname + Quantity_of_ticket + Baggage;
        }

        public static string Sale { get { return sale; } }
        

        public float Road_time() // время в пути
        {
            float road_time;
            Console.WriteLine("Enter the departure time: ");
            float dep_time = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the arrival time: ");
            float arrival_time = float.Parse(Console.ReadLine());

            Console.WriteLine("Time in road:  ");
            road_time = arrival_time - dep_time;
           Console.WriteLine (road_time);
            return road_time;
        }

        public float Get_price() //цена билета
        {
            float price = Road_time();
            
            if(price < 5.0)
            {
                Console.WriteLine("The ticket cost is 50$");
            }
            else if (price >= 5.0 && price <= 99.0)
            {
                Console.WriteLine("The ticket cost is 100$ ");
            }
            else
            {
               Console.WriteLine("The ticket cost is 200$");
            }

            return price;
        }

        public bool Get_express()
        {
            Console.WriteLine("Enter the train Number: ");
            Number = Int32.Parse(Console.ReadLine());
            if (Number < 120)
            {
                Console.WriteLine("Train is espress");
                return true;
            }
            else
                Console.WriteLine("Train isn't express");
            return false;
        }

        public void Marshrut(ref string dest, string arriv)
        {
            dest = "Minsk";
            arriv = "Ufa";
            Console.WriteLine(dest + " - " + arriv);
        }

        public void zone_sum()
        {
            Console.WriteLine("1 zone = 40 km.");
            Console.WriteLine("Enter the Destination: ");
            Destination = Console.ReadLine();
            Console.WriteLine("Enter the Departure: ");
            Departure = Console.ReadLine();
           double time = Road_time();
            if (time < 5.0)
            {
                Console.WriteLine("It will be 1 zone -- " + zone1 + " km.");
            }
            else if (time >= 5.0 && time <= 10.0)
            {
                Console.WriteLine("Iy will be 2 zones --  " + (zone1 += zone1) + " km.");
            }
            else
            {
                Console.WriteLine("It will be 3 zones -- " + zone1*3 + " km.");
            }
            
        }

        public void Start()
        {
            Console.WriteLine("You bought a ticket");
        }


    }
}
