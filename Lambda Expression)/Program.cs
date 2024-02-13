using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_
{
    public delegate string delName(string fristName);
    internal class Program
    {
        static void Main(string[] args)
        {
            delName intsDel = (scendName) =>
            {
                return " Hello " + scendName + " have a good day";

            };
            string str = intsDel.Invoke("Rubel_Habib");
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
