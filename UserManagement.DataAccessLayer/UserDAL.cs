using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.EntityLayer.DataEntity;

namespace UserManagement.DataAccessLayer
{
    public class UserDAL
    {
        public List<tblUserDetail> GetAllUsers()
        {
            using(var context = new DbCRUDEntities())
	        {
                return context.tblUserDetails.ToList();
	        }    
        }

        public void AddUser(tblUserDetail userDetail)
        {
            using (var context = new DbCRUDEntities())
            {
                context.tblUserDetails.Add(userDetail);
                context.SaveChanges();
            }
        }

        public tblUserDetail GetUser(int? id)
        {
            using (var context = new DbCRUDEntities())
            {
                return context.tblUserDetails.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public void EditUser(tblUserDetail userDetail)
        {
            using (var context = new DbCRUDEntities())
            {
                context.Entry(userDetail).State = EntityState.Modified;
                context.SaveChanges();
            }

        }

        public void DeleteUser(int? id)
        {
            using (var context = new DbCRUDEntities())
            {
                context.tblUserDetails.Remove(context.tblUserDetails.Find(id));
                context.SaveChanges();
            }

        }

    }
}
