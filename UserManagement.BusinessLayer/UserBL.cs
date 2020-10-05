using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.DataAccessLayer;
using UserManagement.EntityLayer.DataEntity;

namespace UserManagement.BusinessLayer
{
    public class UserBL
    {
        private UserDAL userDL = new UserDAL();
        public List<tblUserDetail> GetAllUsers()
        {
            return userDL.GetAllUsers();
        }

        public void AddUser(tblUserDetail userDetail)
        {
            userDL.AddUser(userDetail);
        }

        public tblUserDetail GetUser(int? id)
        {
            return userDL.GetUser(id);
        }

        public void EditUser(tblUserDetail userDetail)
        {
            userDL.EditUser(userDetail);
        }

        public void DeleteUser(int? id)
        {
            userDL.DeleteUser(id);
        }


    }
}
