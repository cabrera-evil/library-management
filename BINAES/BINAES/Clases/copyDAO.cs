using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BINAES.SQL_Server;

namespace BINAES.Clases
{
    internal class Copy_DAO
    {
        public List<COPY_> simpleSearch(string text, string id_format)
        {
            using (db_BINAES db = new db_BINAES())
            {
                return db.COPY_.SqlQuery("SELECT *" +
                    "FROM COPY_ C " +
                    "WHERE C.name_ like '%" + text + "%' AND C.id_format = " + id_format).ToList();
            }
        }
        public List<COPY_> SearchPartialTitle(string text, string id_format, bool key_words, bool author, string word, string strAuthor)
        {
            if (!key_words && author)
            {
                using (db_BINAES db = new db_BINAES())
                {
                    return db.COPY_.SqlQuery("SELECT *" +
                    "FROM COPY_ " +
                    "LEFT JOIN AUTHOR " +
                    "    ON COPY_.id = AUTHOR.id_copy " +
                    "WHERE COPY_.name_ like '%" + text + "%' " +
                    "    OR AUTHOR.name_ like '%" + strAuthor + "%'" +
                    "    AND COPY_.id_format = " + id_format).ToList();
                }
            }
            else if (key_words && !author)
            {
                using (db_BINAES db = new db_BINAES())
                {
                    return db.COPY_.SqlQuery("SELECT *" +
                    "FROM COPY_ " +
                    "LEFT JOIN WORDS_LIST " +
                    "    ON COPY_.id = WORDS_LIST.id_copy " +
                    "WHERE COPY_.name_ like '%" + text + "%' " +
                    "    OR WORDS_LIST.word like '" + word + "'" +
                    "    AND COPY_.id_format = " + id_format).ToList();
                }
            }
            else if (key_words && author)
            {
                using (db_BINAES db = new db_BINAES())
                {
                    return db.COPY_.SqlQuery("SELECT *" +
                    "FROM COPY_ " +
                    "LEFT JOIN AUTHOR " +
                    "    ON COPY_.id = AUTHOR.id_copy " +
                    "LEFT JOIN WORDS_LIST " +
                    "    ON COPY_.id = WORDS_LIST.id_copy " +
                    "WHERE COPY_.name_ like '%" + text + "%' " +
                    "    OR AUTHOR.name_ like '%" + strAuthor + "%'" +
                    "    OR WORDS_LIST.word like '" + word + "'" +
                    "    AND COPY_.id_format = " + id_format).ToList();
                }
            }
            else
            {
                using (db_BINAES db = new db_BINAES())
                {
                    return db.COPY_.SqlQuery("SELECT *" +
                        "FROM COPY_ C " +
                        "WHERE C.name_ like '%" + text + "%' AND C.id_format = " + id_format).ToList();
                }
            }
        }

        public List<COPY_> SearchFullTitle(string text, string id_format, bool key_words, bool author, string word, string strAuthor)
        {
            if (!key_words && author)
            {
                using (db_BINAES db = new db_BINAES())
                {
                    return db.COPY_.SqlQuery("SELECT *" +
                    "FROM COPY_ " +
                    "LEFT JOIN AUTHOR " +
                    "    ON COPY_.id = AUTHOR.id_copy " +
                    "WHERE COPY_.name_ like '" + text + "' " +
                    "    OR AUTHOR.name_ like '%" + strAuthor + "%'" +
                    "    AND COPY_.id_format = " + id_format).ToList();
                }
            }
            else if (key_words && !author)
            {
                using (db_BINAES db = new db_BINAES())
                {
                    return db.COPY_.SqlQuery("SELECT *"+
                    "FROM COPY_ " +
                    "LEFT JOIN WORDS_LIST " +
                    "    ON COPY_.id = WORDS_LIST.id_copy " +
                    "WHERE COPY_.name_ like '" + text + "' " +
                    "    OR WORDS_LIST.word like '" + word + "'" +
                    "    AND COPY_.id_format = " + id_format).ToList();
                }
            }
            else if (key_words && author)
            {
                using (db_BINAES db = new db_BINAES())
                {
                    return db.COPY_.SqlQuery("SELECT *" +
                    "FROM COPY_ " +
                    "LEFT JOIN AUTHOR " +
                    "    ON COPY_.id = AUTHOR.id_copy " +
                    "LEFT JOIN WORDS_LIST " +
                    "    ON COPY_.id = WORDS_LIST.id_copy " +
                    "WHERE COPY_.name_ like '"+text+"' " +
                    "    OR AUTHOR.name_ like '%"+strAuthor+"%'" +
                    "    OR WORDS_LIST.word like '"+word+"'" +
                    "    AND COPY_.id_format = " + id_format).ToList();
                }
            }
            else
            {
                using (db_BINAES db = new db_BINAES())
                {
                    return db.COPY_.SqlQuery("SELECT *" +
                         "FROM COPY_ C " +
                         "WHERE C.name_ like '" + text + "' AND C.id_format = " + id_format).ToList();
                }
            }

        }

        public List<FORMAT_> get_format()
        {
            using (db_BINAES db = new db_BINAES())
            {
                return db.FORMAT_.ToList();
            }
        }
    }
}
