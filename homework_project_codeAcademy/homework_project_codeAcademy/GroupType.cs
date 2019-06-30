using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_project_codeAcademy
{
    class GroupType
    {
        private static int ID;
        public string Name { get; set; }
        public float Payment { get; set; }

        public GroupType(string name,float payment)
        {
            ID++;
            Name = name;
            Payment = payment;
        }
    }
}
