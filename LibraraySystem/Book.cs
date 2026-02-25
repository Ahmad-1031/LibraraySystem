using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraraySystem
{
    class Book
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Status { get; set; }
        public string IsDeleted { get; set; }

        public Book(string title, string author, string description, string genre)
        {
            Title = title;
            Author = author;
            Description = description;
            Genre = genre;
            Status = "A";
            IsDeleted = "N";
        }

        public static int GetNextBookID()
        {
            string sqlQuery = "SELECT MAX(BookID) FROM BOOKS";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            int nextID;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextID = 1;
            }
            else
            {
                nextID = dr.GetInt32(0) + 1;
            }

            dr.Close();
            return nextID;
        }

        public static bool BookExists(string title, string author)
        {
            string sql = "SELECT COUNT(*) FROM Books WHERE BOOKTITLE = :title AND AUTHOR = :author";

            OracleParameter[] parameters = {

            new OracleParameter(":title",title),
            new OracleParameter(":author",author)
            };

            int count = Convert.ToInt32(Database.ExecuteScalar(sql, parameters));
            if(count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }

        public void AddBook()
        {
            string sqlQuery = "INSERT INTO Books (BOOKID, GENRECODE, BOOKTITLE, AUTHOR, DESCRIPTION, STATUS, ISDELETED)" +
                "VALUES (:id, :genre, :title, :author, :description, :status, :isDeleted)";

            OracleParameter[] parameters =
            {
                new OracleParameter(":id",Id),
                new OracleParameter(":genre",Genre),
                new OracleParameter(":title",Title),
                new OracleParameter(":author",Author),
                new OracleParameter(":description",Description),
                new OracleParameter(":status",Status),
                new OracleParameter(":isDeleted",IsDeleted)

            };

            Database.ExecuteNonQuery(sqlQuery, parameters);
        }

        public override string ToString()
        {
            string str = "Book Details: \n\n";

            str += Title + "\n" +
                    Author + "\n" +
                    Description + "\n" +
                    Genre + "\n";
            return str;
        }

        
    }
}
