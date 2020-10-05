using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.EntityLayer.BusinessEntity
{
    class UserDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public string Gender { get; set; }
    }
}
