using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GunOdev5Deneme2
{
    class JanuaryCampaign : ICampaignManager
    {
        public void Add(Games games)
        {
            Console.WriteLine("Bu oyunu Ocak ayına özel % 70 indirim ile aldınız: " 
                + games.GameName + "   İyi Günler Dileriz");
        }

        public void Delete()
        {
            throw new NotImplementedException("Oyunlarımızda Artık İndirim Mevcut Değildir");
        }

        public void Update(Games games)
        {
            throw new NotImplementedException("Bu oyundaki indirim şubat ayındada mevcuttur : " + games.GameName);
        }
    }
}
