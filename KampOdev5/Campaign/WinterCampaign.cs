using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev5.Campaign
{
    public class WinterCampaign : ICampaignService
    {
        void ICampaignService(Game game)
        {
            game.CurrentPrice -= game.CurrentPrice * (0.3);
            Console.WriteLine("Kış  İndirimi Uygulandı");
        }
    }
}
