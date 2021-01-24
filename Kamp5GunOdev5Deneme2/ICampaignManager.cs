using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GunOdev5Deneme2
{
    interface ICampaignManager
    {
        void Add(Games games);
        void Delete();

        void Update(Games games);
    }
}
