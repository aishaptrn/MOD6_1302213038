using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_1302213038
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void increasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID Video\t: " + this.id);
            Console.WriteLine("Judul Video\t: " + this.title);
            Console.WriteLine("View Count\t: " + this.playCount);
        }

        public int getPlayCount() 
        { 
            return this.playCount;
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}
