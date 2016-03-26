using System;

/*Problem 15.	** Torrent Pirate*/

namespace TorrentPirate
{
    class TorrentPirate
    {
        static void Main()
        {
            int d = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());

            double downloadTime = (d / 2 / 60 / 60);
            double priceForDownload = (downloadTime * w);
            double numberOfMoviesDownloaded = (d / 1500);

            double cinemaPrice = (numberOfMoviesDownloaded * p);
            double mallPrice = (downloadTime * w);

            if (cinemaPrice < mallPrice)
            {
                Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
            }
            else
            {
                Console.WriteLine("mall -> {0:F2}lv", mallPrice);
            }
        }
    }
}
