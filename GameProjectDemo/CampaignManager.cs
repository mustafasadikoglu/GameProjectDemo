using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " "+" isimli kampanya eklendi. ");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + " isimli kampanya silindi. ");
        }

        public void NewPrice(Campaign campaign)
        {                       
            Console.WriteLine("Yeni Kampanya Fiyatına Göre Hesaplandı.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + " isimli kampanya güncellendi. ");
        }
    }
}
