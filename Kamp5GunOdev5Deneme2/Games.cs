using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GunOdev5Deneme2
{
    class Games:GameManager
    {
        public string GameName { get; set; }

        public void Buy(Players players,Games games)
        {
            Console.WriteLine("Bu Oyun Satın Alındı : "+ games.GameName + "  Sayın : " 
                + players.FirstName + players.LastName );
        }
    }
}
