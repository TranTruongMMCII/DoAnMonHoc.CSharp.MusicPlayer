using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.DTO
{
    public class User
    {
        private int id;
        private string username;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public User(DataRow dataRow)
        {
            this.Id = Convert.ToInt32(dataRow["id"].ToString());
            this.Username = dataRow["username"].ToString();
            this.Password = dataRow["password"].ToString();
        }
    }
}
