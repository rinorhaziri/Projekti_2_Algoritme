using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] stringu = new String[50];
            stringu[0] = "GG";
            stringu[1] = "GG";
            stringu[2] = "GR";



            LittleElephanAndRGB le = new LittleElephanAndRGB();
            Console.WriteLine("Numri i katërsheve (a,b,c,d) për stringun e dhënë me numër minimal të 'G' : "+le.getNumber(stringu, 5));
            
            Console.ReadLine();
        }
    }
}
