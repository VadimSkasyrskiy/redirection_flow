using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace redirection_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);


            double a1, a2, a3, a4, a5;
            double s, k;

            a1 = double.Parse(Console.ReadLine());
            a2 = double.Parse(Console.ReadLine());
            a3 = double.Parse(Console.ReadLine());
            a4 = double.Parse(Console.ReadLine());
            a5 = double.Parse(Console.ReadLine());

            if((a3 == 0) || ((a2 - a1 + a3) < 0))
            {
                Console.WriteLine("ERROR!");
            } 
            else
            {
                s = ((Math.Sqrt(a2 - a1 + a3)) / a3) + (a4 / 100);
                Console.WriteLine(s);
            }

            if(((a1 - a3) <= 0) || ((a3 + a4) < 0))
            {
                Console.WriteLine("ERROR!");
            } 
            else
            {
                k = ( Math.Sqrt(((a3 + a4) / (a1 - a3))) * Math.Pow((a2 - a5), 2) );
                Console.WriteLine(k);
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

        }
    }
}
