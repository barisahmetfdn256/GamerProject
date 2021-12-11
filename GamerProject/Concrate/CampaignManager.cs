using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Concrate
{
    class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya Başarıyla Eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya Başarıyla Silindi.");
        }

        public void UpDate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya Başarıyla Güncellendi.");
        }
    }
}
