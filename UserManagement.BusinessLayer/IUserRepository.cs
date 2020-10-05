using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.EntityLayer.DataEntity;

namespace UserManagement.BusinessLayer
{
    public interface IUserRepository
    {
        void AddUser(tblUserDetail userDetail);
        void DeleteUser(int? id);
        void EditUser(tblUserDetail userDetail);
        List<tblUserDetail> GetAllUsers();
        tblUserDetail GetUser(int? id);
    }
}
