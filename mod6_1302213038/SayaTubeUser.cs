using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace mod6_1302213038
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            Contract.Requires(username.Length <= 100);
            Contract.Requires(username != null);
            
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
            Contract.Requires(video != null);
            Contract.Requires(video.getPlayCount() < int.MaxValue);

            this.uploadedVideos.Add(video);
        }

        public void printAllVideoPlayCount()
        {
            Contract.Requires(uploadedVideos.Count() < 9);
            
            Console.WriteLine("User\t\t: Aish");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1) + " judul\t: " + uploadedVideos[i].getTitle());
            }
        }
    }
}
