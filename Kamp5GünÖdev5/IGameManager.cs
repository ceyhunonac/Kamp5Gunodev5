using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GünÖdev5
{
    interface IGameManager
    {
        void Buy(Player player);
        void Campaign(ICampaignManager campaignManager);

        


    }
}
