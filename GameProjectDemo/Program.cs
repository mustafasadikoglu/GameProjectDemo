using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1,
                BirthYear = 1993, 
                FirstName = "Mustafa", 
                LastName = "Sadıkoğlu", 
                IdentityNumber = 12345 
            });

            SteamSalesPlatformManager steamSalesPlatformManager = new SteamSalesPlatformManager();
            steamSalesPlatformManager.ToSell(new Gamer { Id=1,FirstName="Mustafa"});

            CampaignManager campaignManager = new CampaignManager();
            Campaign c = new Campaign { CampaignId = 1, CampaignName = "NewYearCampany", CampaignCalc = 0.20 };
            campaignManager.Add(c);
           
        }
    }
}
