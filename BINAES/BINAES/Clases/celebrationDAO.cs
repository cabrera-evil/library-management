using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using BINAES.SQL_Server;

namespace BINAES.Clases
{
    public class celebrationDAO
    {
        public List<CELEBRATION> show_celebration()
        {
            using (db_BINAES db = new db_BINAES())
            {
                return db.CELEBRATION.ToList();
            }
        }

        public List<GOAL> set_goal()
        {
            using (db_BINAES db = new db_BINAES())
            {
                return db.GOAL.ToList();
            }
        }
    }
}