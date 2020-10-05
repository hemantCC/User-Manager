using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.EntityLayer.DataEntity;

namespace UserManagement.DataAccessLayer
{
    public class LoginDL
    {
        public bool ValidateUser(tblLogin LoginUser)
        {
            using (var context = new DbCRUDEntities())
            {
                Boolean isValid = context.tblLogins.Any(x => x.Username == LoginUser.Username && x.Password == LoginUser.Password);
                return isValid;
            }

        }
    }
}
