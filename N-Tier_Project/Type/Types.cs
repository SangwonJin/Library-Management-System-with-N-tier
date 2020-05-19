using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type
{
    public struct ParmStruct
    {
        public ParmStruct(string name, object value,
            SqlDbType dataType, ParameterDirection direction = ParameterDirection.Input, int size = 0)
        {
            Name = name;
            Value = value;
            Size = size;
            DataType = dataType;
            Direction = direction;
        }

        public string Name;
        public object Value;
        public int Size;
        public SqlDbType DataType;
        public ParameterDirection Direction;

    }
    public enum ResourceType
    {
        Manufacturers_DVD,
        Manufacturers_Reference_Manual,
        NonManufacturers_Reference_Book
    }

    public enum ResourceStatus
    {
        Available,
        On_Loan,
        Not_Available_For_Loan

    }
    public enum LoanStatus
    {
        On_Loan,
        Returned,
        Returned_Damaged,
        Not_Returned

    }
    public enum ProgramOption
    {
        Regular_Program,
        Block_Release
    }
    public enum InstructorType
    {
        DepartmentHead,
        Instructor
    }



}
