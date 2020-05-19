using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;
using Type;

namespace Repository
{
   public class ListsRepo
    {

        public List<StudentLookUp> RetrieveStudentsList(string keyword)
        {
            DataAccess db = new DataAccess();
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@Keyword", keyword, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            DataTable dt = db.Execute("spRetrieveStudentLookup", CommandType.StoredProcedure,parms);
            List<StudentLookUp> students = new List<StudentLookUp>();
            foreach(DataRow row in dt.Rows)
            {
                students.Add(
                    new StudentLookUp()
                    {
                        StudentId = row["StudentId"].ToString(),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString()
                    }
                ) ; 
            }
            return students;
        }
        public List<LoanLookUp> RetrieveLoanList(string id)
        {
            DataAccess db = new DataAccess();
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@StudentId", id, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            DataTable dt = db.Execute("spRetrieveCurrentLoans", CommandType.StoredProcedure, parms);
            List<LoanLookUp> Loans = new List<LoanLookUp>();
            foreach (DataRow row in dt.Rows)
            {
                Loans.Add(
                    new LoanLookUp()
                    {
                        StudendId = row["StudentId"].ToString(),
                        ResourceId = Convert.ToInt32(row["ResourceId"]),
                        ResourceTitle = row["Title"].ToString(),
                        ResoruceType = (ResourceType)row["ResourceType"],
                        CheckOutDate = Convert.ToDateTime(row["CheckoutDate"]),
                        ImageOfItem = row["ImageOfItem"].ToString()

                    }
                );
            }
            return Loans;
        }
        public DateTime getStudendStartDate(string keyword)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@studentId", keyword, SqlDbType.NVarChar, ParameterDirection.Input,8));


            string sql = "SELECT StartDate FROM Student WHERE StudentId = @studentId";
            DataAccess db = new DataAccess();
            return Convert.ToDateTime(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

    }
}
