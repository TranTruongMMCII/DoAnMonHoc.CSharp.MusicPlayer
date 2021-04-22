using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMP.DTO;

namespace EMP.DAL
{
    public class UserDAL
    {
        private static UserDAL instance;

        public static UserDAL Instance {
            get { 
                if (instance == null)
                {
                    instance = new UserDAL();
                }
                return instance;
            }
            set => instance = value; }
        
        private UserDAL()
        {

        }

        #region login
        public User login(string username, string password)
        {
            string query = $"select * from dbo.users where username = '{username}' and password = '{password}';";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                return new User(dataRow);
            }
            return null;
        }
        #endregion

        #region insert
        public bool insert(string username, string password)
        {
            string query = $"insert into dbo.users(username, password) values ('{username}', '{password}');";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        public User getUserByUserName(string username)
        {
            string query = $"select * from dbo.users where username = '{username}';";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                return new User(dataRow);
            }
            return null;
        }

        public User getUserById(int id)
        {
            string query = $"select * from dbo.users where id = {id};";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                return new User(dataRow);
            }
            return null;
        }

        public bool updateUser(int id, string password)
        {
            string query = $"update dbo.users set password = '{password}' where id = {id};";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<User> getUsers()
        {
            List<User> users = new List<User>();

            string query = "select * from dbo.users;";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                users.Add(new User(dataRow));
            }

            return users;
        }

        public void deleteUser(int user_id)
        {
            string query = $"delete from dbo.users where id = {user_id};";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
