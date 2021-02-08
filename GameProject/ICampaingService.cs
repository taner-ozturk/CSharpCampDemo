using System;
namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaign campaing);
        void Update(Campaign campaing);
        void Delete(Campaign campaing);
    }
}