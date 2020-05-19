using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using Type;
using System.Data;

namespace Repository
{
    public class StudentRepo
    {
        public Student RetrieveById(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@StudentId", id, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("spRetrieveStudentOne", CommandType.StoredProcedure, parms);

            return PopulateStudentRecord(dt.Rows[0]);
        }
        public bool InsertStudent(Student s)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@StudentId", s.StudentId, SqlDbType.NChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@LastName", s.lastName, SqlDbType.NVarChar, ParameterDirection.Input, 20));
            parms.Add(new ParmStruct("@FirstName", s.FirstName, SqlDbType.NVarChar, ParameterDirection.Input, 30));
            parms.Add(new ParmStruct("@Address", s.Address, SqlDbType.NVarChar, ParameterDirection.Input, 30));
            parms.Add(new ParmStruct("@City", s.City, SqlDbType.NVarChar, ParameterDirection.Input, 20));
            parms.Add(new ParmStruct("@PostalCode", s.PostalCode, SqlDbType.Char, ParameterDirection.Input, 7));
            parms.Add(new ParmStruct("@Telephone", s.Telephon, SqlDbType.NVarChar, ParameterDirection.Input, 13));
            parms.Add(new ParmStruct("@ProgramOption", s.Program, SqlDbType.TinyInt, ParameterDirection.Input));
            parms.Add(new ParmStruct("@StartDate", s.StartDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new ParmStruct("@EndDate", s.EndDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new ParmStruct("@IsActive", s.IsActive, SqlDbType.Bit, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            return (db.ExecuteNonQuery("spInsertStudent", CommandType.StoredProcedure, parms) > 0);

        }
        public bool UpdateStudent(Student s)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@TimeStamp", s.TimeStamp, SqlDbType.Timestamp, ParameterDirection.InputOutput));
            parms.Add(new ParmStruct("@StudentId", s.StudentId, SqlDbType.NChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@LastName", s.lastName, SqlDbType.NVarChar, ParameterDirection.Input, 20));
            parms.Add(new ParmStruct("@FirstName", s.FirstName, SqlDbType.NVarChar, ParameterDirection.Input, 30));
            parms.Add(new ParmStruct("@Address", s.Address, SqlDbType.NVarChar, ParameterDirection.Input, 30));
            parms.Add(new ParmStruct("@City", s.City, SqlDbType.NVarChar, ParameterDirection.Input, 20));
            parms.Add(new ParmStruct("@PostalCode", s.PostalCode, SqlDbType.Char, ParameterDirection.Input, 7));
            parms.Add(new ParmStruct("@Telephone", s.Telephon, SqlDbType.NVarChar, ParameterDirection.Input, 12));
            parms.Add(new ParmStruct("@ProgramOption", s.Program, SqlDbType.TinyInt, ParameterDirection.Input));
            parms.Add(new ParmStruct("@StartDate", s.StartDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new ParmStruct("@EndDate", s.EndDate, SqlDbType.Date, ParameterDirection.Input));
            parms.Add(new ParmStruct("@IsActive", s.IsActive, SqlDbType.Bit, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            if (db.ExecuteNonQuery("spUpdateStudent", CommandType.StoredProcedure, parms) > 0)
            {
                s.TimeStamp = (byte[])parms[0].Value;
                return true;
            }
            return false;

        }
        public bool DeleteStudent(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@StudentId", id, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            DataAccess db = new DataAccess();
           return db.ExecuteNonQuery("spDeleteStudent", CommandType.StoredProcedure, parms) > 0;
        }
        public bool Check_loan(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@StudentId", id, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            DataAccess db = new DataAccess();
            string sql = "SELECT Count(*) FROM loan WHERE StudentId = @StudentId";
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms)) > 0;
        }
        public bool Check_ReservedItem(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@StudentId", id, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            DataAccess db = new DataAccess();
            string sql = "SELECT Count(*) FROM Resource WHERE StudentId = @StudentId";
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms)) > 0;
        }
        public decimal Check_Balance(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@StudentId", id, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            DataAccess db = new DataAccess();
            string sql = "SELECT BalanceDue FROM Student WHERE StudentId = @StudentId";
            return Convert.ToDecimal(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        private Student PopulateStudentRecord(DataRow row)
        {
            Student s = new Student();

           
            s.StudentId = row["studentId"].ToString();
            s.FirstName = row["FirstName"].ToString();
            s.lastName = row["LastName"].ToString();
            s.Address = row["Address"].ToString();
            s.Telephon = row["Telephone"].ToString();
            s.City = row["city"].ToString();
            s.PostalCode = row["postalcode"].ToString();
            s.Program = (ProgramOption)row["Program"];
            s.EndDate = Convert.ToDateTime(row["EndDate"]);
            s.StartDate = Convert.ToDateTime(row["StartDate"]);
            s.BalanceDue = Convert.ToDecimal(row["BalanceDue"].ToString());
            s.IsActive = Convert.ToBoolean(row["IsActive"]);
            s.TimeStamp = (byte[])row["TimeStamp"];


            return s;
        }

       
    }
}
