using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork2;
using System.IO;

namespace HomeWork2
{
    class Program
    {
        public static object TextFile1 { get; private set; }

        static void Main(string[] args)
        {
            //Task1.Exs1();
            // Task1.Exs2();
            // Task1.Exs3();
            // Task1.Exs4();
            //Task1.Exs5();

            //Задание 2.
            //class TRAIN

            //стоимость билета и время в пути
            //var value = new Train();
            //value.Get_price();

            // экспресс
            //var ex = new Train();
            //ex.Get_express();

            // передача значения по cссылке
            //var marsh = new Train();
            //string dest = "Moscow";
            //string arriv = "London";
            //marsh.Marshrut(ref dest, arriv);
            //Console.WriteLine(marsh);

            //статическая переменная
            //Train.zone1 = 40;
            //var zone = new Train();
            //zone.zone_sum();

            //Статический конструктор
            // Console.WriteLine("The sale for students and retirement pensioner = " + Train.Sale + " %");

            //массив. данные для покупки билета
           // Console.WriteLine("Enter information for bying ticket: ");
           //Train[] newFile = new Train[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    newFile[i] = new Train();

            //    Console.WriteLine("Enter the name: ");
            //    newFile[0].Name = Console.ReadLine();

            //    Console.WriteLine("Enter the surname: ");
            //    newFile[0].Surname = Console.ReadLine();

            //    Console.WriteLine("What quantity of ticket do you need: ");
            //    newFile[0].Quantity_of_ticket = Int32.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter your age: ");
            //    newFile[0].Age = Int32.Parse(Console.ReadLine());

            //    Console.WriteLine("Do you have a baggage? \n(enter '0' - if yes or '1' if you travelling without baggage): ");
            //    newFile[0].Baggage = bool.Parse(Console.ReadLine());
            //    newFile[0].ToString();
            //}

            Train val = new Train();
            val.Start();
            val.Finish();

            Console.WriteLine();
            Console.ReadLine();
        }

        
       
    }

    partial class Train
    {
        public void Finish()
        {
            Console.WriteLine("Thanks for choosing our company!");
        }
    }
}
