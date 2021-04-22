using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.DTO
{
    public class Song
    {
        private int id;
        private string url;

        public int Id { get => id; set => id = value; }
        public string Url { get => url; set => url = value; }

        public Song(DataRow dataRow)
        {
            this.Id = Convert.ToInt32(dataRow["id"].ToString());
            this.Url = dataRow["url"].ToString();
        }
    }
}
