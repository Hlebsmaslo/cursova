using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace cinema
{
    public class Reservation
    {
        public int OrderCode { get; set; }
        public int id { get; set; }
        public Reservation(int orderCode)
        {
            OrderCode = orderCode;
        }
    }

}
