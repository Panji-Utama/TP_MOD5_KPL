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

            Console.WriteLine("\n");

            SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Tutorial Design By Contract – [" + namaPrak + "]");
            sayaTubeVideo.PrintVideoDetails();

            SayaTubeVideo test = new SayaTubeVideo("Makalah merupakan karya tulis ilmiah yang dibuat untuk menghasilkan suatu gagasan terhadap permasalahan. Karya ilmiah ini terbilang memiliki bobot kesulitan yang cukup tinggi, tapi masih lebih mudah jika dibandingkan dengan skripsi.");
            test.PrintVideoDetails();

            Console.WriteLine("\n");

            sayaTubeVideo.IncreasePlayCount(10);

            Console.WriteLine(sayaTubeVideo.getPlayCount());

            sayaTubeVideo.IncreasePlayCount(69696969);

            Console.WriteLine(sayaTubeVideo.getPlayCount());


        }
    }
}
