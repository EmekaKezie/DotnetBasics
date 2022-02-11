using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    class Properties
    {
        int empId;
        string empName;
        string empRole;

        public int GetEmpId()
        {
            return empId;
        }

        public int SetEmptId(int id)
        {
            this.empId = id;
            return id;
        }


        private string GetEmpName()
        {
            return empName;
        }

        public string SetEmpName(string name)
        {
            this.empName = name;
            return name;
        }


        public string GetEmpRole()
        {
            return empRole;
        }

        public string SetEmpRole(string role)
        {
            this.empRole = role;
            return role;
        }
    }
}
