using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GünÖdev5
{
    interface ICampaignManager
    {
        void Add(ICampaignManager campaignManager);

        void Delete();

        void Update();
        void Add();
    }
}
