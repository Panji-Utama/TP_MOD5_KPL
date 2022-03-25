using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302200089
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nama praktikan: ");
            string namaPrak = Console.ReadLine();

            SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Tutorial Design By Contract – [" + namaPrak + "]");
            //Console.WriteLine(sayaTubeVideo.getTitle());
            sayaTubeVideo.PrintVideoDetails();
        }
    }
}
