using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_project_codeAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupType groupType = new GroupType("Proqramlashdirma",3500);
            GroupType groupType2 = new GroupType("Dizayn", 3000);
            GroupType groupType3 = new GroupType("Sistem Administrasiyasi", 2800);
            GroupType groupType4 = new GroupType("3D Dizayn", 2300);
            


            CodeGroup group1 = new CodeGroup("P111",3,groupType);
            CodeGroup group2 = new CodeGroup("P222", 4, groupType2);
            CodeGroup group3 = new CodeGroup("P333", 3, groupType3);
            CodeGroup group4 = new CodeGroup("P444", 4, groupType4);
            



            Student student = new Student("Javid", "Bashirov", "Ehmedli", 25,3500,groupType);
            Student student2 = new Student("Kenan", "Eliyev", "Bakixanov", 28, 3000, groupType2);
            Student student3 = new Student("Imran", "Babayev", "Nerimanov", 27, 1500, groupType3);
            Student student4 = new Student("Xeyal", "Agayev", "Suraxani", 25, 2300, groupType4);
            Student student5 = new Student("Araz", "Eliyev", "Bileceri", 25, 3500, groupType);
            Student student6 = new Student("Ilkin", "Eliyev", "Bineqedi", 30, 500, groupType4);
            Student student7 = new Student("Huseyn", "Babayev", "Qaracuxur", 25, 3500, groupType);
            Student student8 = new Student("Elshad", "Abdullayev", "Genclik", 35, 1300, groupType);
            Student student9 = new Student("Reshad", "Babayev", "Xirdalan", 25, 3000, groupType2);
            Student student10 = new Student("Xeyale", "Eliyeva", "Ehmedli", 30, 2800, groupType3);
            Student student11 = new Student("Ilham", "Babayev", "Qaracuxur", 25, 3500, groupType);
            Student student12 = new Student("Nurane", "Abdullayeva", "Genclik", 35, 1300, groupType);
            Student student13 = new Student("Kamran", "Babayev", "Xirdalan", 25, 2800, groupType3);
            Student student14 = new Student("Elshad", "Abdullayev", "Genclik", 35, 3000, groupType2);
            Student student15 = new Student("Aysun", "Babayeva", "Xirdalan", 25, 1500, groupType3);

            group1.CreateNewStudent(student);
            group2.CreateNewStudent(student2);
            group1.CreateNewStudent(student3);
            group4.CreateNewStudent(student4);
            group2.CreateNewStudent(student5);
            group1.CreateNewStudent(student6);
            group2.CreateNewStudent(student7);
            group4.CreateNewStudent(student8);
            group3.CreateNewStudent(student9);
            group3.CreateNewStudent(student10);
            group4.CreateNewStudent(student11);
            group1.CreateNewStudent(student12);
            group3.CreateNewStudent(student13);
            group2.CreateNewStudent(student14);
            group4.CreateNewStudent(student15);

        }
    }
}
