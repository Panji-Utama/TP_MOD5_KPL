using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302200089
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            //Contract.Requires(title != null);
            //Contract.Requires(title.Length < 100);
            Debug.Assert(title.Length < 100 && title != null, "Length nama jangan lebih dari 100 dan jangan juga NULL!");

            this.title = title;
            Random random = new Random();
            id = random.Next(0, 100000);
            playCount = 0;
        }

        public void IncreasePlayCount(int angka)
        {
            try
            {
                if (angka > 10000000) throw new Exception("playCount maksimal 10.000.000!");
                playCount = playCount + angka;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(title.Length);
            Console.WriteLine("vidID \t\t: " + id);
            Console.WriteLine("vidTitle \t: " + title);
            Console.WriteLine("vidPlayCount \t: " + playCount);
        }

        public int getPlayCount() 
        {
            Console.Write("Play Count saat ini: ");
            return playCount; 
        }

        //public string getTitle()
        //{
        //    return title;
        //}
    }
}
