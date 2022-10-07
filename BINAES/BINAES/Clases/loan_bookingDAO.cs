using BINAES.SQL_Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES.Clases
{
    internal class loan_bookingDAO
    {
        public List<LOAN_BOOKING> loan_booking()
        {
            using (db_BINAES db = new db_BINAES())
            {
                return db.LOAN_BOOKING.ToList();
            }
        }
    }
}
