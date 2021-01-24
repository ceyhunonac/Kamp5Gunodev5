using System;
using System.Collections.Generic;

namespace Kamp5GunOdev5Deneme2
{
    class Program
    {
        static void Main(string[] args)
        {
            Players player1 = new Players();
            player1.TcNo = 32434454545;
            player1.FirstName = "Ceyhun";
            player1.LastName = "Onaç";
            player1.BirthYear = 2003;


            List<Players> players = new List<Players>() { player1 };
            foreach (var player in players)
            {

                if (player1.BirthYear < 2010 || player1.TcNo > 000000000000)
                {
                    Console.WriteLine("Doğrulama Başarılı");
                }
                else
                {
                    Console.WriteLine("Doğrulama başarısız");
                    return;
                }

                Games game1 = new Games();
                game1.GameName = "Call Of Duty Cold War";
                Games game2 = new Games();
                game2.GameName = "The Last Of Us";

                List<Games> games = new List<Games>() {game1,game2 };
                foreach (var  game in games)
                {

                }
                //
                GameManager gamemanager = new Games();
                gamemanager.Buy(player1 , game1);

                ICampaignManager campaignManager = new JanuaryCampaign();
                campaignManager.Add(game1);
            }
        }
    }

}