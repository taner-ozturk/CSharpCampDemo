using System;
using GameProject;


    class CampaingManager : ICampaignService
    {
        public void Add(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName + " yüklendi.");
        }

        public void Delete(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName + " silindi.");
        }

        public void Update(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName + " güncellendi.");
        }
    }
