using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GünÖdev5
{
    class JanuaryDiscountCampaign : ICampaignManager
    {
       

       

        public void Add()
        {
            Console.WriteLine("Bu Oyunlarda Ocak Ayı İndirimi Geçerli(%70 İndirim)");
        }

        public void Add(ICampaignManager campaignManager)
        {
            Console.WriteLine("Bu Oyunlarda Ocak Ayı İndirimi Geçerli(%70 İndirim)");
        }

        public void Delete()
        {
            Console.WriteLine("Bu Oyunlarda Ocak Ayı İndirimi Bitmiştir");
        }

        public void Update()
        {
            Console.WriteLine("Bu Oyunlarda Ocak Ayına Kadar Geçerli İndirimi Şubat Ayına Kadar Uzattık (%70 İndirim)");
        }
    }
}
