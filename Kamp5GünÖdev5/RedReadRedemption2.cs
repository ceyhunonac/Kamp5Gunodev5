using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GünÖdev5
{
    class RedReadRedemption2 : IGameManager
    {
     

        public void Buy(Player player)
        {
            Console.WriteLine("Red Read Redemption 2 adlı oyun başarıyla satın alındı : " + player.FirstName);
        }

        public void Campaign(ICampaignManager campaignManager)
        {
            Console.WriteLine("Red Read Redemption 2 adlı oyun Ocak Ayı İndirimine Sahip : ");
        }
    }

   

}

