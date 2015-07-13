using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class TorrentPirate
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long data = long.Parse(Console.ReadLine());
        int moneyWouldCostCinema = int.Parse(Console.ReadLine());
        int moneyPerHourWife = int.Parse(Console.ReadLine());
        int movieSize = 1500;

        var downloadTime = ((double)data / 2) / 60 / 60;
        var priceForDownload = downloadTime * moneyPerHourWife;
        var numOfMovies = (double)data / (double)movieSize;
        var cinemaPrice = numOfMovies * moneyWouldCostCinema;
        var mallPrice = priceForDownload;

        if (cinemaPrice < mallPrice)
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
        }
        else if (cinemaPrice >= mallPrice)
        {
            Console.WriteLine("mall -> {0:F2}lv", mallPrice);
        }

    }
}