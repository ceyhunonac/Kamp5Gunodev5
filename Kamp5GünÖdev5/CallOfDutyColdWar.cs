using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GünÖdev5
{
    class CallOfDutyColdWar : IGameManager
    {
        public void Buy(Player player)
        {
            Console.WriteLine("Call Of Duty Cold War adlı oyun başarıyla satın alındı : " + player.FirstName);
        }

        public void Campaign(ICampaignManager campaignManager)
        {
            Console.WriteLine("Call Of Duty Cold War adlı oyun Ocak Ayı İndirimine Sahip : ");
        }
    }
}
