using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            String str = "Member Details:\n\n";

            str += $"Member ID: M00{MemID}" + "\n" +
                   $"First Name: {Fname}" + "\n" +
                   $"Surname: {Sname}" + "\n" +
                   $"Phone Number: {Phone}" + "\n" +
                   $"Email: {Email}" + "\n";
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

        public static DataSet FindMemberByName(string name)
        {
            String sql = "SELECT MEMID, FNAME, SNAME, PHONE, EMAIL FROM MEMBERS " +
                "WHERE FNAME LIKE :name AND ISDELETED = 'N' " +
                "ORDER BY FNAME";
            OracleParameter[] parameters = {
                new OracleParameter(":name","%" + name + "%"),
                
            };
            return Database.ExecuteMultiRowQuery(sql, parameters);
        }

        public static DataSet FindMemberByID(int id)
        {
            String sql = "SELECT MEMID, FNAME, SNAME, PHONE, EMAIL FROM MEMBERS " +
                "WHERE MEMID = :id AND ISDELETED = 'N'";

            OracleParameter[] parameters = {
                new OracleParameter(":id",id)

            };

            return Database.ExecuteMultiRowQuery (sql, parameters);

        }

        public static Member GetMember(int id)
        {
            string sqlQuery = "SELECT * FROM MEMBERS WHERE MEMID = :id AND ISDELETED = 'N'";

            OracleParameter[] parameters =
            {
                new OracleParameter(":id",id)
            };
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery, parameters);
            dr.Read();

            string Fname = dr.GetString("FNAME");
            string Sname = dr.GetString("SNAME");
            int Phone = int.Parse(dr.GetString("PHONE"));
            string Email = dr.GetString("EMAIL");

            dr.Close();

            return new Member(id, Fname, Sname, Phone, Email);


        }

        public void UpdateMember()
        {
            String sqlQuery = "UPDATE MEMBERS SET " +
                "FNAME = :fname, " +
                "SNAME = :sname, " +
                "PHONE = :phone, " +
                "EMAIL = :email " +
                "WHERE MEMID = :id";

            OracleParameter[] parameters = {
            new OracleParameter (":fname",Fname),
            new OracleParameter (":sname",Sname),
            new OracleParameter (":phone",Phone),
            new OracleParameter (":email",Email),
            new OracleParameter(":id",MemID)
        };

            Database.ExecuteNonQuery(sqlQuery, parameters);
        }

        public void RemoveMember()
        {
            String sqlQuery = "UPDATE MEMBERS SET " +
                "ISDELETED = 'Y' " +
                "WHERE MEMID = :id";

            OracleParameter[] parameters = {
               new OracleParameter(":id",MemID)
            };

            Database.ExecuteNonQuery(sqlQuery, parameters);
        }

    }
}
