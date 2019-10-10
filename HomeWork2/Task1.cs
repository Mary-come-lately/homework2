//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace HomeWork2
//{
//    class Task1
//    {
//        public static void Exs1()
//        {
//            Console.WriteLine("Enter the string: ");
//            char str;
//            int count = 0;
//            do
//            {
//                str = Console.ReadKey().KeyChar;
//                if (str == ' ')
//                    count++;
//            }
//            while (str != '.');

//            Console.WriteLine();
//            Console.WriteLine("Quantity of symbols: " + count);

//        }

//        public static void Exs2()
//        {
//            Console.WriteLine("Enter the ticket number: ");
//            string str = Console.ReadLine();
//            char[] arr = new char[str.Length];
//            arr = str.ToCharArray();
//            int[] Ticket = arr.Select(s => Convert.ToInt32(s)).ToArray();
//            if (arr.Length == 6)
//            {
//                int sumLeft = 0;
//                int sumRight = 0;

//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if (i < 3)
//                    {
//                        sumLeft += Ticket[i];
//                    }

//                    else sumRight += Ticket[i];
//                }

//                if (sumLeft == sumRight)
//                {
//                    Console.WriteLine("Happy Ticket");
//                }

//                else Console.WriteLine("Unhappy ticket");
//            }

//            else Console.WriteLine("Enter the correct number!");

//            Console.Read();
//        }


//        public static void Exs3()
//        {
//            Console.WriteLine("Enter your string: ");
//            string str = Console.ReadLine();
//            char[] s = str.ToCharArray();
//            for (int i = 0; i < s.Length; i++)
//            {
//                if (Char.IsUpper(s[i]))
//                {
//                    s[i] = Char.ToLower(s[i]);
//                }
//                else
//                {
//                    s[i] = Char.ToUpper(s[i]);
//                }
//            }
//            Console.WriteLine(String.Concat(s));
//            Console.ReadLine();
//        }

//        public static void Exs4()
//        {

//            Console.WriteLine("If A = 3 and B = 7: ");
//            for (int i = 3; i < 8; i++)
//            {
//                Console.WriteLine();

//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write(i);
//                }
//            }

//            Console.ReadLine();
//        }

//        public static void Exs5()
//        {
//            Console.WriteLine("Enter the number: ");
//            int number = Int32.Parse(Console.ReadLine());
//            Console.WriteLine(number.ToString().Reverse().ToArray());
//            Console.ReadLine();
//        }
//    }
//}

 