using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace FlowWalletMiner
{
    internal class Program
    {

        public static void numerkitegotypu()
        {
            const string src = "0123456789";
            int length = 5;
            var sb = new StringBuilder();
            Random RNG = new Random();
            for (var i = 0; i < length; i++)
            {
                var c = src[RNG.Next(0, src.Length)];
                sb.Append(c);
            }
            Console.Write(sb.ToString());
            int kaska = sb.ToString().Length;
        }
       
        public static void random()
        {
            const string src = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int length = 48;
            var sb = new StringBuilder();
            Random RNG = new Random();
            for (var i = 0; i < length; i++)
            {
                var c = src[RNG.Next(0, src.Length)];
                sb.Append(c);
            }
            Console.Write(sb.ToString());
        }
        


        private static void gen()
        {
            for (int i = 1; i <= 1241; i++)
            {
                Thread.Sleep(20);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("                        FLOW MINER ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("'");
                Console.ForegroundColor = ConsoleColor.Red;
                random();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("'");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(" (0.00000 BTC)");
                Console.WriteLine();
                
            }
}

        static void Main(string[] args)
        {





            Console.Title = "Flow Miner V2.0";
            Logo();
            string s = "Welcome To Flow Miner V2.0";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Thread.Sleep(1000);
            Console.Clear();
            Logo();
            string sd = "[1] Start Wallet Mining";
            Console.SetCursorPosition((Console.WindowWidth - sd.Length) / 2, Console.CursorTop);
            Console.WriteLine(sd);
            string sda = "[2] Exit";
            Console.SetCursorPosition((Console.WindowWidth - sda.Length) / 2, Console.CursorTop);
            Console.WriteLine(sda);


            string wyburpdw = Console.ReadLine();

            if (wyburpdw == "1")
            {
                Console.Title = "Loading Flow Miner";
                asgard();
                string sdda = "Connecting To Server";
                Console.SetCursorPosition((Console.WindowWidth - sdda.Length) / 2, Console.CursorTop);
                Console.Write(sdda);
                Thread.Sleep(2500);
                asgard();
                string sgda = "Connected To France-1";
                Console.SetCursorPosition((Console.WindowWidth - sgda.Length) / 2, Console.CursorTop);
                Console.WriteLine(sgda);
                Thread.Sleep(1500);
                asgard();
                string sgsda = "Loading 1200 Private Pools";
                Console.SetCursorPosition((Console.WindowWidth - sgsda.Length) / 2, Console.CursorTop);
                Console.Write(sgsda);
                Thread.Sleep(2500);
                int hit = 0;
                asgard();
                string sagsda = "Loading 128 Proxies";
                Console.SetCursorPosition((Console.WindowWidth - sagsda.Length) / 2, Console.CursorTop);
                Console.WriteLine(sagsda);
                Thread.Sleep(1500);
                asgard();
                string sfagsda = "Miner will start in 5 seconds";
                Console.SetCursorPosition((Console.WindowWidth - sfagsda.Length) / 2, Console.CursorTop);
                Console.WriteLine(sfagsda);
                Console.Title = "Flow Miner - Start in 5 sec";
                Thread.Sleep(1000);
                Console.Title = "Flow Miner - Start in 4 sec";
                Thread.Sleep(1000);
                Console.Title = "Flow Miner - Start in 3 sec";
                Thread.Sleep(1000);
                Console.Title = "Flow Miner - Start in 2 sec";
                Thread.Sleep(1000);
                Console.Title = "Flow Miner - Start in 1 sec";
                Thread.Sleep(1000);
                int kaska = 0;
                asgard();
                Console.Title = "Flow Miner V2.0  Hits = " + hit;
                gen();
                Thread.Sleep(125);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("                        FLOW MINER ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("'");
                Console.ForegroundColor = ConsoleColor.Green;
                random();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("'");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(" (0.");
                numerkitegotypu();
                Console.WriteLine(" BTC)");
                int hits = 1;
                Console.Title = "Flow Miner V2.0  Hits = " + hits;
                Console.WriteLine();
                Thread.Sleep(1800);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Found BTC! Saving to ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wallet.txt");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Thanks for using our service!");
                Thread.Sleep(2000);
                
            }

            else if (wyburpdw == "2")
            {
                Environment.Exit(420);
            }



            Thread.Sleep(5000);
        }








        public static void Logo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine("                                          ███████╗██╗      █████╗  ██╗       ██╗");
            Console.WriteLine("                                          ██╔════╝██║     ██╔══██╗ ██║  ██╗  ██║");
            Console.WriteLine("                                          █████╗  ██║     ██║  ██║ ╚██╗████╗██╔╝");
            Console.WriteLine("                                          ██╔══╝  ██║     ██║  ██║  ████╔═████║ ");
            Console.WriteLine("                                          ██║     ███████╗╚█████╔╝  ╚██╔╝ ╚██╔╝ ");
            Console.WriteLine("                                          ╚═╝     ╚══════╝ ╚════╝    ╚═╝   ╚═╝  ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void asgard()
        {
            Console.Clear();
            Logo();
        }
    }
}
