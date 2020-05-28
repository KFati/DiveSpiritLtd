using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOMDiveSpirit.Business
{
    public class clsLogInBL
    {
        // Login
        public Common.clsUser Login(Common.clsLogInData objLogIn)
        {
            // Read voter
            Data.clsUserDA objUserSystemDA = new Data.clsUserDA();
            var objUserSystem = objUserSystemDA.Read(objLogIn);

            if (objUserSystem.Username is null)
                throw new Exception("Invalid Login!");

            if (!objLogIn.UserType.Equals(objUserSystem.UserType) || !objLogIn.Username.Equals(objUserSystem.Username) || !objLogIn.Password.Equals(objUserSystem.Password))
                throw new Exception("Invalid Login!");

            return objUserSystem;
        }
    }
}
