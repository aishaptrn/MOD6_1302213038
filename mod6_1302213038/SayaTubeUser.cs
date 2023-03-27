using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_1302213038
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int getTotalVideoPlayCount()
        {
            int sum = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                sum += uploadedVideos[i].getPlayCount();
            }
            return sum;
        }

        public void addVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }

        public void printAllVideoPlayCount()
        {
            Console.WriteLine("User\t\t: Aish");

            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1) + " judul\t: " + uploadedVideos[i].getTitle());
            }
        }
    }
}
