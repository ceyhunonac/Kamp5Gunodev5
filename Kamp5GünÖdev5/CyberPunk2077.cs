using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GünÖdev5
{
    class CyberPunk2077 : IGameManager
    {
        public void Buy(Player player)
        {
            Console.WriteLine("CyberPunk 2077 adlı oyun başarıyla satın alındı : " + player.FirstName);
        }

        public void Campaign(ICampaignManager campaignManager)
        {
            Console.WriteLine("CyberPunk 2077 adlı oyun Ocak Ayı İndirimine Sahip : ");
        }
    }
}
