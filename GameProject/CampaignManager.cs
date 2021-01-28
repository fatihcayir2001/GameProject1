using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void EndOfYearCampaign(Player player, Game game)
        {
            Console.WriteLine(player.FirstName + " için " + game.Name + " oyununa yılsonu kampanyası uygulandı");
        }

        public void NewYearCampaign(Player player, Game game)
        {
            Console.WriteLine(player.FirstName + " için " + game.Name + " oyununa yeniyıl kampanyası uygulandı");
        }
        public void Delete()
        {
            Console.WriteLine("Kampanya silindi");
        }
    }
}
