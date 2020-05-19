using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Type;
using Model;
using System.Data;

namespace Repository
{
    public class ResourceRepo
    {
        public Resource RetrieveById(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@resourceId", id, SqlDbType.Int, ParameterDirection.Input, int.MaxValue));
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("spRetrieveResourceOne", CommandType.StoredProcedure, parms);

            return PopulateResourceRecord(dt.Rows[0]);
        }

        public bool InsertResource(Resource r)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@ResourceId", r.ResourceId, SqlDbType.Int, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@Title", r.Title, SqlDbType.NVarChar, ParameterDirection.Input, 50));
            parms.Add(new ParmStruct("@Publisher", r.Publisher, SqlDbType.NVarChar, ParameterDirection.Input, 30));
            parms.Add(new ParmStruct("@ResourceType", r.ResourceType, SqlDbType.TinyInt, ParameterDirection.Input, 30));
            parms.Add(new ParmStruct("@PubRefNumber", r.PubRefNumber, SqlDbType.NVarChar, ParameterDirection.Input, 20));
            parms.Add(new ParmStruct("@PurchasePrice", r.PurchasePrice, SqlDbType.Money, ParameterDirection.Input));
            parms.Add(new ParmStruct("@DateOfPurchase", r.DateOfPurchase, SqlDbType.Date, ParameterDirection.Input, 13));
            parms.Add(new ParmStruct("@ResourceStatus", r.ResourceStatus, SqlDbType.TinyInt, ParameterDirection.Input));
            parms.Add(new ParmStruct("@ImageOfItem", r.ImageOfItem, SqlDbType.NVarChar, ParameterDirection.Input));


            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("spInsertResource", CommandType.StoredProcedure, parms) > 0;
        }

        public Resource RetrieveByIdForResourceOnLoan(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@ResourceId", id, SqlDbType.Int, ParameterDirection.Input, int.MaxValue));
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("spRetriveBorrowerAndResource", CommandType.StoredProcedure, parms);

            return PopulateResourceRecord(dt.Rows[0]);
        }
        private Resource PopulateResourceRecord(DataRow row)
        {
            Resource r = new Resource();
            r.ResourceId = Convert.ToInt32(row["ResourceId"]);
            r.StudentId = row["StudentId"].ToString();
            r.Title = row["Title"].ToString();
            r.ResourceType = (ResourceType)row["ResourceType"];
            r.ResourceStatus = (ResourceStatus)row["ResourceStatus"];
            r.IsReserved = Convert.ToBoolean(row["isReserved"]);

            return r;
        }

        public bool changeReservation(int resourceId, int reserved, string studentId = null)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
  
            parms.Add(new ParmStruct("@ResourceId", resourceId, SqlDbType.Int, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@reserved", reserved, SqlDbType.Int, ParameterDirection.Input,1));
            string sql = "UPDATE Resource SET IsReserved = @reserved, StudentId = null WHERE ResourceId = @ResourceId";
           
            if (studentId != null)
            {
                parms.Add(new ParmStruct("@studentId", studentId, SqlDbType.NVarChar, ParameterDirection.Input, 8));
                sql = "UPDATE Resource SET IsReserved = @reserved, StudentId = @studentId WHERE ResourceId = @ResourceId";
            }

           
            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery(sql, CommandType.Text, parms) > 0;
        }


    }
}
