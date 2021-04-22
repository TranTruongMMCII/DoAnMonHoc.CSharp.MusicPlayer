using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMP.DTO;

namespace EMP.DAL
{
    public class SongDAL
    {
        private static SongDAL instance;

        public static SongDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SongDAL();
                }
                return instance;
            }
            set => instance = value;
        }

        private SongDAL()
        {

        }

        #region getbyID
        public Song getSongById(int id)
        {
            string query = $"select * from dbo.songs where id = {id};";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                return new Song(dataRow);
            }
            return null;
        }
        #endregion

        #region insert
        public bool insert(string url)
        {
            string query = $"insert into dbo.songs(url) values (N'{url}');";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        public Song getSongByURL(string url)
        {
            string query = $"select * from dbo.songs where url = N'{url}';";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                return new Song(dataRow);
            }
            return null;
        }

        public int getIdBySongUrl(string url)
        {
            string query = $"select * from dbo.songs where url = N'{url}';";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                return new Song(dataRow).Id;
            }
            return -1;
        }
    }
}
