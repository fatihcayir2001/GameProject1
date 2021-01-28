using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonDol playerManager = new PlayerManager();
            Player player = new Player() { Id = 1, BirthYear=2001,FirstName="Fatih",LastName="Çayır",TC=1235};
            Game game = new Game() { Id = 1, Name = "CS:GO", UnitPrice = 10 };
            UserValidationManager userValidation = new UserValidationManager();
            if (userValidation.Validate(player) == true)
            {
                playerManager.Add(player);

            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
            }
            
           
            SellingManager selling = new SellingManager();
            selling.Sell();
            CampaignManager campaign = new CampaignManager();
            campaign.EndOfYearCampaign(player, game);
            campaign.Delete();

        }
    }
}
