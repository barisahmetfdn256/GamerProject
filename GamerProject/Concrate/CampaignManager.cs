using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Concrate
{
    class CampaignManager : ICampaignManager
    {
        List<Campaign> campaigns = new List<Campaign>();
        public CampaignManager()
        {

        }
        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya Başarıyla Eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            campaigns.Remove(campaign);
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya Başarıyla Silindi.");
        }

        public List<Campaign> GetAll()
        {
            return campaigns;
            foreach (var camp in campaigns)
            {
                Console.WriteLine(camp.CampaignName);
            }
        }

        public void UpDate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya Başarıyla Güncellendi.");
        }
    }
}
