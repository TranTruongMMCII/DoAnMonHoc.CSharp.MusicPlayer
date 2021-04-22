using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.DTO
{
    public class PlayList
    {
        private int id_user;
        private int id_song;

        public int Id_user { get => id_user; set => id_user = value; }
        public int Id_song { get => id_song; set => id_song = value; }

        public PlayList(DataRow dataRow)
        {
            this.Id_user = Convert.ToInt32(dataRow["id_user"].ToString());
            this.Id_song = Convert.ToInt32(dataRow["id_song"].ToString());
        }
    }
}
