using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMP.DTO;

namespace EMP.DAL
{
    class PlaylistDAL
    {
        private static PlaylistDAL instance;

        public static PlaylistDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlaylistDAL();
                }
                return instance;
            }
            set => instance = value;
        }

        private PlaylistDAL()
        {

        }

        public List<int> getAllSongIDByUserId(int id)
        {
            string query = $"select * from dbo.playlists where id_user = {id};";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<int> res = new List<int>();
            foreach(DataRow dataRow in data.Rows)
            {
                res.Add(Convert.ToInt32(dataRow["id_song"].ToString()));
            }

            return res;
        }

        public List<Song> getAllSongBaseOnSongId(List<int> id)
        {
            List<Song> songs = new List<Song>();
            string query = "";

            foreach(int i in id)
            {
                query = $"select * from dbo.songs where id = {i};";
                DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
                foreach(DataRow dataRow in dataTable.Rows)
                {
                    songs.Add(new Song(dataRow));
                }
            }
            return songs;
        }

        public bool insert(int id_user, int id_song)
        {
            string query = $"insert into dbo.playlists(id_user, id_song) values ({id_user}, {id_song});";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool getItem(int id_user, int id_song)
        {
            string query = $"select * from dbo.playlists where id_user = {id_user} and id_song = {id_song};";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if(data != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void deleteItem(int id_user)
        {
            string query = $"delete from dbo.playlists where id_user = {id_user};";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
