using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ApplicationFiles
{
    class Card
    {
        string image;
        int id;
        int status;
        //Status=1 Aktif
        //Status=-1 Oynandı ve desteden çıkarıldı

        public string Image { get => image; set => image = value; }
        public int Id { get => id; set => id = value; }
        public int Status { get => status; set => status = value; }
    }
}
