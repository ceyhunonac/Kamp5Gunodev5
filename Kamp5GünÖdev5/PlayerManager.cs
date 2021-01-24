using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GünÖdev5
{
    class PlayerManager
    {
        public void Add(Player player )
        {
            Console.WriteLine("Oyuncu eklendi : " + player.FirstName);
        }
        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi : " + player.FirstName);
        }
        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi : " + player.FirstName);
        }
    
    
    
    
        }

    
    
}
