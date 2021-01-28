using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class SteamSalesPlatformManager : ISalesPlatformService
    {
        public void ToSell(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" "+"Oyunu Steam Üzerinden Alındı.");
        }
    }
}
