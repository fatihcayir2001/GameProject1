using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {

            if (player.Id == 1 && player.FirstName == "Fatih" && player.LastName == "Çayır" && player.BirthYear == 2001 && player.TC == 1235)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
