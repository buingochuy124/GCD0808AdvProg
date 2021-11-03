using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeASM
{
    interface IUser
    {
        int GetStudentId();
        string GetStudentName();
        string GetStudentDescription();
        void PrintStudentInfomation();    
    }
    public class Admin : IUser
    {
        public string GetStudentDescription()
        {
            throw new NotImplementedException();
        }

        public int GetStudentId()
        {
            throw new NotImplementedException();
        }

        public string GetStudentName()
        {
            throw new NotImplementedException();
        }

        public void PrintStudentInfomation()
        {
            throw new NotImplementedException();
        }
    }

}
