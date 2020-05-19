using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type;
using System.Data;
using DAL;
using Model;

namespace Repository
{
    public class LoanRepo
    {
        public bool Transaction(string studentid, int resourceId, DateTime checkoutDate, DateTime dueDate)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@StudentId", studentid, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@resourceId", resourceId, SqlDbType.Int, ParameterDirection.Input, int.MaxValue));
            parms.Add(new ParmStruct("@CheckOutDate", checkoutDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@DueDate", dueDate, SqlDbType.DateTime, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("spCheckoutResource", CommandType.StoredProcedure, parms) > 0;

        }
        public bool Return(string studentid, int resourceId, DateTime returnDate,  int loanStatus)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@StudentId", studentid, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@ResourceId", resourceId, SqlDbType.Int, ParameterDirection.Input, int.MaxValue));
            parms.Add(new ParmStruct("@DateReturned", returnDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@LoanStatus", loanStatus, SqlDbType.Int, ParameterDirection.Input));
            //parms.Add(new ParmStruct("@LoanId",loanId,SqlDbType.Int,ParameterDirection.Input));
            //parms.Add(new ParmStruct("@DueDate", dueDate, SqlDbType.DateTime, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("spReturnResources", CommandType.StoredProcedure, parms) > 0;

        }

        public int Check_SameType(string studentId, int resourceType)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@studentId", studentId, SqlDbType.NVarChar, ParameterDirection.Input, int.MaxValue));
            parms.Add(new ParmStruct("@resourceType", resourceType, SqlDbType.Int, ParameterDirection.Input, int.MaxValue));

            string sql = "SELECT count(*) FROM Student " +
                "INNER JOIN Loan ON Student.StudentId = Loan.StudentId " +
                "INNER JOIN Resource ON Resource.ResourceId = Loan.ResourceId " +
                "WHERE ResourceType = @resourceType  AND Loan.StudentId = @studentId AND loan.DateReturned is null";
            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }
        public bool Check_Reservation(string studentId, int resourceId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@studentId", studentId, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@resourceId", resourceId, SqlDbType.Int, ParameterDirection.Input, int.MaxValue));

            string sql = "SELECT Count(*) FROM Student " +
                "INNER JOIN Resource ON Student.StudentId = Resource.StudentId " +
                "WHERE Resource.StudentId = @studentId AND Resource.ResourceId = @resourceId";
            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms)) > 0;
        }

        //This part for return
        public int CalculateDate(string studentId, int resourceId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@StudentId", studentId, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@ResourceId", resourceId, SqlDbType.Int, ParameterDirection.Input, int.MaxValue));
            //parms.Add(new ParmStruct("@DateReturned", returnDate, SqlDbType.DateTime, ParameterDirection.Input));

            string sql =
              //" DECLARE @LoanId int; " +
              //" SET @LoanId = (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND StudentId = @StudentId ) " +
              "SELECT DATEDIFF(DAY, Loan.DueDate, Loan.DateReturned) FROM Loan" +
              "  WHERE LoanId IN(SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId)" +
              "  AND StudentId = @StudentId)";
            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

    }
}
