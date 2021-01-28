using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1993 && gamer.FirstName == "Mustafa" && gamer.LastName == "Sadıkoğlu" && gamer.IdentityNumber == 12345)
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
