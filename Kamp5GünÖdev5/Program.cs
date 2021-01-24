using System;
using System.Collections.Generic;

namespace Kamp5GünÖdev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = "13233423434";
            player1.FirstName = "Ceyhun";
            player1.LastName = "Onaç";
            player1.BirthYear = 2003;

            List<Player> players = new List<Player>() {player1};
            foreach (var player in players) 
            {
                Console.WriteLine("Oyuncu Tc.NO = " +player.Id);
                Console.WriteLine("Oyuncu İsmi = " + player.FirstName);
                Console.WriteLine("Oyuncu Soyadı = " + player.LastName);
                Console.WriteLine("Oyuncu Doğum Yılı = " + player.BirthYear);

               


                PlayerManager playermanager = new PlayerManager();
                playermanager.Add(player1);


                IGameManager gameManager = new RedReadRedemption2();
                gameManager.Buy(player1);

                ICampaignManager campaignManager = new JanuaryDiscountCampaign();
                campaignManager.Add();

            }

        }
    }
}
