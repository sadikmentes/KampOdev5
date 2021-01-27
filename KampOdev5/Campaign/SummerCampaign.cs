using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev5.Campaign
{
   public class SummerCampaign : ICampaignService
    {
      
        void ICampaignService(Game game)
        {
            game.CurrentPrice -= game.CurrentPrice * (0.2);
            Console.WriteLine("Yaz İndirimi Uygulandı");
        }
    }
}
