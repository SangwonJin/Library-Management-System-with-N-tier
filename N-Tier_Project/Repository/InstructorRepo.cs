using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Type;

namespace Repository
{
    public class InstructorRepo
    {
        public InstructorType RetrieveType(string useranme,string password)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
           
            parms.Add(new ParmStruct("@username", useranme, SqlDbType.NVarChar, ParameterDirection.Input, 20));
            parms.Add(new ParmStruct("@Password", password, SqlDbType.NVarChar, ParameterDirection.Input,10));
            //parms.Add(new ParmStruct("@Result", 0, SqlDbType.Int, ParameterDirection.Output, 0));


            DataAccess db = new DataAccess();
            int type = Convert.ToInt32(db.ExecuteScaler("spLogin", CommandType.StoredProcedure, parms));
            return (InstructorType)type;
        }
        public bool InsertInstructor(string useranme, string password, InstructorType type)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@username", useranme, SqlDbType.NVarChar, ParameterDirection.Input, 20));
            parms.Add(new ParmStruct("@Password", password, SqlDbType.NVarChar, ParameterDirection.Input, 10));
            parms.Add(new ParmStruct("@InstructorType", type, SqlDbType.Int, ParameterDirection.Input, 1));


            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("spInsertInstructor", CommandType.StoredProcedure, parms) > 0;
        }
    }
}
