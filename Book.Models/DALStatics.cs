using DataAccessLayer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class DALStatics
    {
        public static List<UserInfo> Users = new List<UserInfo>()
        {
            new UserInfo()
            {
                Username = "om_admin",
                EmailAddress = "om.admin@tatvasoft.com",
                Password = "Admin_pwd123",
                GivenName = "Om",
                Surname = "Rathod",
                Role = "Administrator"
            },

            new UserInfo()
            {
                Username = "john_reader",
                EmailAddress = "john.user@tatvasoft.com",
                Password = "john_pwd",
                GivenName = "John",
                Surname = "Doe",
                Role = "BookUser"
            },
        };
    }
}
