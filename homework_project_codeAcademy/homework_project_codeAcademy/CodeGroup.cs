using System;

namespace homework_project_codeAcademy
{
    class CodeGroup
    {

        private static int ID;
        public string Name { get; set; }
        public byte StudentCount { get; set; }

        private GroupType Type;

        private Student[] ListStudent;



        public CodeGroup(string name, byte countt, GroupType type)
        {
            ID++;
            Name = name;
            StudentCount = countt;
            Type = type;
            ListStudent = new Student[0];

        }

        public void CreateNewStudent(Student students)
        {
           
                if (students.StudentMoney == Type.Payment && StudentCount > ListStudent.Length)
                {
                    Array.Resize(ref ListStudent, ListStudent.Length + 1);
                    ListStudent[ListStudent.Length - 1] = students;
                    Console.WriteLine($"{students.Name} {students.Surname}:Qebul oldunuz.Tebrikler ");

                }
                else
                {
                    Console.WriteLine($"{students.Name} {students.Surname}:Qebul olmadiz.Teessufler");
                }
            
        }
    }
}
