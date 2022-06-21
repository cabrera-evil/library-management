using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using BINAES.SQL_Server;

namespace BINAES.Clases
{
    public class collectionsDAO
    {
        public List<COLLECTION_> show_collection()
        {
            using (db_BINAES db = new db_BINAES())
            {
                return db.COLLECTION_.ToList();
            }
        }

        public List<TYPE_> set_type()
        {
            using (db_BINAES db = new db_BINAES())
            {
                return db.TYPE_.ToList();
            }
        }

        public List<GENRE> set_genre()
        {
            using (db_BINAES db = new db_BINAES())
            {
                return db.GENRE.ToList();
            }
        }
    }
}