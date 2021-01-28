using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void NewYearCampaign(Player player, Game game);
        void EndOfYearCampaign(Player player, Game game);
        void Delete();
        
        
    }
}
