namespace mod6_1302213038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test SayaTubeVideo");
            SayaTubeVideo vid = new SayaTubeVideo("Test Video");
            vid.increasePlayCount(1864);
            vid.printVideoDetails();

            Console.WriteLine("\nTest SayaTubeUser");
            SayaTubeUser usr = new SayaTubeUser("Aisha");

            SayaTubeVideo vid1 = new SayaTubeVideo("Review Film " +
                "<Heaven Official's Blessing> oleh Aisha Putri Nuryan");
            vid1.increasePlayCount(3000);
            SayaTubeVideo vid2 = new SayaTubeVideo("Review Film " +
                "<Omniscient Reader's Viewpoint> oleh Aisha Putri Nuryan");
            vid2.increasePlayCount(1865);
            SayaTubeVideo vid3 = new SayaTubeVideo("Review Film " +
                "<Garden of Words> oleh Aisha Putri Nuryan");
            vid3.increasePlayCount(1229);
            SayaTubeVideo vid4 = new SayaTubeVideo("Review Film " +
                "<The Song of Achilles> oleh Aisha Putri Nuryan");
            vid4.increasePlayCount(536);
            SayaTubeVideo vid5 = new SayaTubeVideo("Review Film " +
                "<Fairy Tail: 100 Years Quest> oleh Aisha Putri Nuryan");
            vid5.increasePlayCount(100);
            SayaTubeVideo vid6 = new SayaTubeVideo("Review Film " +
                "<5 Centimeters per Second> oleh Aisha Putri Nuryan");
            vid6.increasePlayCount(51827);
            SayaTubeVideo vid7 = new SayaTubeVideo("Review Film " +
                "<Your Name> oleh Aisha Putri Nuryan");
            vid7.increasePlayCount(118299);
            SayaTubeVideo vid8 = new SayaTubeVideo("Review Film " +
                "<Everything All at Once> oleh Aisha Putri Nuryan");
            vid8.increasePlayCount(6473);
            SayaTubeVideo vid9 = new SayaTubeVideo("Review Film " +
                "<Howl's Moving Castle> oleh Aisha Putri Nuryan");
            vid9.increasePlayCount(143341);
            SayaTubeVideo vid10 = new SayaTubeVideo("Review Film " +
                "<The Forest of Fireflies> oleh Aisha Putri Nuryan");
            vid10.increasePlayCount(1352);

            usr.addVideo(vid1);
            usr.addVideo(vid2);
            usr.addVideo(vid3);
            usr.addVideo(vid4);
            usr.addVideo(vid5);
            usr.addVideo(vid6);
            usr.addVideo(vid7);
            usr.addVideo(vid8);
            usr.addVideo(vid9);
            usr.addVideo(vid10);

            usr.printAllVideoPlayCount();
        }
    }
}