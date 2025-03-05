using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<trieuchung2> a = new List<trieuchung2>();
            for (int i = 0; i < 4; i++)
            {
                trieuchung2 x = new trieuchung2();
                x.matrieuchung = i + "";
                x.tentrieuchung = "hiv" + i;
                a.Add(x);
            }
            trieuchung2 y = new trieuchung2();
            y.matrieuchung = "2";
            y.tentrieuchung = "hiv2";
            a.Remove(y);
            foreach (trieuchung2 x in a)
            {
                Console.WriteLine(x.matrieuchung +""+ x.tentrieuchung);

            }
            //List<string> a = new List<string>();
            //a.Add("Khong");
            //a.Add("Mot");
            //a.Add("Hai");
            //a.Add("Ba Bon");

            //foreach(string i in a)
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadLine();
        }
    }
}
