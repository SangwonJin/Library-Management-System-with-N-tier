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
    public class PaymentRepo
    {
        public bool makePayment(Payment_Entity p)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@StudentId", p.StudentId, SqlDbType.NVarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@AmountOfPayment",p.AmountOfPayment, SqlDbType.SmallMoney, ParameterDirection.Input));
            parms.Add(new ParmStruct("@PaymentDate",p.Date , SqlDbType.DateTime, ParameterDirection.Input));


            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("spMakePayment", CommandType.StoredProcedure, parms) > 0;

        }
    }
}
