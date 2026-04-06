using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraraySystem
{
    class Member
    {
        public int MemID { get; set; }
        public String Fname {  get; set; }
        public String Sname {  get; set; }
        public int Phone {  get; set; }
        public String Email {  get; set; }
        public Char IsDeleted {  get; set; }

        public Member(int id, String fname, String sname, int phone, String email)
        {
            MemID = id;
            Fname = fname;
            Sname = sname;
            Phone = phone;
            Email = email;
            IsDeleted = 'N';
        }

        public override string ToString() {
            String str = "Member Details:\n ";

            str += "M00" + MemID + "\n" +
                   Fname + "\n" +
                   Sname + "\n" +
                   Phone + "\n" +
                   Email + "\n" +
                   IsDeleted;
            return str;
        }

        public static int NextMemID() {
            string sqlQuery = "SELECT MAX(MEMID) FROM MEMBERS";
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

        public static bool MemberExists(int phone, String email) {
            string sql = "SELECT COUNT(*) FROM MEMBERS WHERE PHONE = :phone OR EMAIL = :email";

            OracleParameter[] parameters = {

            new OracleParameter(":phone",phone),
            new OracleParameter(":email",email)
            };

            int count = Convert.ToInt32(Database.ExecuteScalar(sql, parameters));
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddMember()
        {
            string sqlQuery = "INSERT INTO Members (MEMID, FNAME, SNAME, PHONE, EMAIL, ISDELETED)" +
                "VALUES (:memid, :fname, :sname, :phone, :email, :isdeleted)";

            OracleParameter[] parameters = {
                new OracleParameter(":memid",MemID),
                new OracleParameter(":fname",Fname),
                new OracleParameter(":sname",Sname),
                new OracleParameter(":phone",Phone),
                new OracleParameter(":email",Email),
                new OracleParameter(":isdeleted",IsDeleted)

            };

            Database.ExecuteNonQuery(sqlQuery, parameters);
        }

    }
}
