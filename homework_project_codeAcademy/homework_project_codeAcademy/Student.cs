using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_project_codeAcademy
{
    class Student
    {
        
        private static int ID;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public byte Age { get; set; }
        public float StudentMoney { get; set; }

        private GroupType Type;


        public Student(string name,string surname,string address,byte age,float money,GroupType studenttype)
        {
            ID++;
            Name = name;
            Surname = surname;
            Address = address;
            Age = age;
            StudentMoney =money;
            Type = studenttype;




        }

    }
}
