using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise.Entities.Departments
{
    class Department
    {

        public string  departmentName { get; set; }


         public Department() { }

        public Department(string name )
        {
            departmentName = name;
        }

    }
}
