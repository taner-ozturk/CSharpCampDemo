using System;
using GameProject;


    class GameSellManager : ISaleService
    {
        public double _campaignPrice;

        public GameSellManager(Campaign campaign, Game game)
        {
            _campaignPrice = game.GamePrice * campaign.CampaignRate;
        }

        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            if (campaign != null)
            {
                Console.WriteLine(game.GameName + " adlı oyun " + gamer.FirstName + " oyuncusu tarafından " + campaign.CampaignName + " adlı kampanyayı kullanarak " + _campaignPrice + " indirim yapılarak satın alındı.");
            }
            else
            {
                Console.WriteLine(game.GameName + " adlı oyun " + gamer.FirstName + " oyuncusu tarafından " + " kampanya kullanılmayarak satın alındı.");
            }
        }


    }

