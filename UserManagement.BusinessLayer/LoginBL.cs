using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.EntityLayer.DataEntity;
using UserManagement.DataAccessLayer;

namespace UserManagement.BusinessLayer
{
    public class LoginBL
    {
        private LoginDL loginDL = new LoginDL();
        public bool ValidateUser(tblLogin LoginUser)
        {
            return loginDL.ValidateUser(LoginUser);
        }
    }
}
