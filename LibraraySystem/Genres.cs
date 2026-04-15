using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraraySystem
{
    class Genres
    {
        public string GenreCode { get; set; }
        public string GenreDesc { get; set; }

        public Genres(string genreCode, string genreDesc) {
            GenreCode = genreCode;
            GenreDesc = genreDesc;
        }

        public static DataSet getGenres() {
            String sqlQuery = "SELECT * FROM GENRES ORDER BY GENRECODE";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}
