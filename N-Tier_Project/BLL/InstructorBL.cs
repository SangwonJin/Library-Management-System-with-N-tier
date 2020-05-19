using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;
using Type;

namespace BLL
{
    public class InstructorBL
    {
        public InstructorType getType(string username, string password)
        {
            InstructorRepo instructorBL = new InstructorRepo();
            return instructorBL.RetrieveType(username, password);

        }
        public bool InsertInstructor(string id, string password, InstructorType type)
        {
            InstructorRepo instructorBL = new InstructorRepo();
            return instructorBL.InsertInstructor(id, password, type);
        }

      
    }
}
