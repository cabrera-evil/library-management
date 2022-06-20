using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINAES.Clases
{
    internal class UserDAO
    {
        public List<USER_> show_user()
        {
            using (db_BINAES db = new db_BINAES())
            {
                return db.USER_.ToList();
            }
        }

        public List<ROLE_> set_role()
        {
            using(db_BINAES db = new db_BINAES())
            {
                return db.ROLE_.ToList();
            }
        }

        public List<OCCUPANCY> set_occupancy()
        {
            using (db_BINAES db = new db_BINAES())
            {
                return db.OCCUPANCY.ToList();
            }
        }

        public List<INSTITUTION> set_institution()
        {
            using (db_BINAES db = new db_BINAES())
            {
                return db.INSTITUTION.ToList();
            }
        }
    }

}
