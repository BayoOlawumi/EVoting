using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace SelfAccessment
{
    public class Program
    {
        public bool Inderter(string filenam)
        {
            StreamReader dt = null;
            try
            {
                dt = new StreamReader(filenam);
                string rd = dt.ReadToEnd();
                dt.Close();
                Console.WriteLine("The length na{0}", new StringInfo(rd).LengthInTextElements);
                return true;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Dok not found");
                return false;
            }
            finally
            {
                if (dt != null)
                {
                    dt.Close();
                    dt.Dispose();
                }
                Console.ReadKey();
            }
        }
            static void Main(string[] args)
        {
            Program nd = new Program();
            nd.Inderter("FileText.txt");
        UIProgram IT = new UIProgram();
            Degree Bachelor = new Degree("Bachelor");
            Degree PostGraduate = new Degree("PostGraduate");
            Course Progamming = new Course("Programming");
            Course Research = new Course("Research");
            IT.Degs = new List<Degree>();
            IT.Degs.Add(Bachelor);
            IT.Degs.Add(PostGraduate);
            Student Std1 = new Student { Name = "Olawumi", Age = 23, Address = "ikosi Ketu" };
            Student Std2 = new Student { Name = "Kolawole", Age = 26, Address = "Osogbo" };
            Student Std3 = new Student { Name = "Oreva", Age = 27, Address = "Warri" };
            Progamming.Stds = new List<Student>();
            Progamming.Stds.Add(Std1);
            Progamming.Stds.Add(Std2);
            Research.Stds = new List<Student>();
            Research.Stds.Add(Std3);
            Progamming.Teach = new List<Teacher>();
            Teacher Tch1 = new Teacher { Name = "Dr. Ale", Age = 43, Address = "Kosowo", Stds = Progamming.Stds };
            TechnicalEmployee Employee2 = new TechnicalEmployee("olawale");
            BusinessEmployee Employee3 = new BusinessEmployee("Feminiyi");
            foreach (var val in IT.Degs)
            {
                val.Cour = new List<Course>();
                switch (val.degname)
                {
                    case ("Bachelor"):
                        val.Cour.Add(Progamming);
                        break;
                    case ("PostGraduate"):
                        val.Cour.Add(Research);
                        break;
                }
                Console.WriteLine("Degree: {0}", val.degname);
                foreach (var col in val.Cour)
                {
                    Console.WriteLine("Available Course include: {0}", col.CourName);
                    int counte = 0;
                    if (col.Stds != null)
                    {
                        foreach (var dts in col.Stds)
                        {
                            counte++;
                            Console.WriteLine(" {0} is offering this course", dts.Name);
                        }
                        Console.WriteLine("We have {0} student(s) offering this course", counte);
                    }
                }
                {

                }
            }
            Console.ReadKey();
        }


    }
}


















//class Program
//{
//    public static void Main()
//    {
//        char r = 'X';
//        for (int a = 0; a <= 8; a++)
//        {
//            for (int b = 0; b <= 8; b++)
//            {
//                if (a % 2 != 0)
//                {
//                    r = 'O';
//                    if (b % 2 != 0)
//                    {
//                        r = 'X';
//                    }
//                }
//                else if (a % 2 == 0)
//                {
//                    r = 'O';
//                    if (b % 2 == 0)
//                    {
//                        r = 'X';
//                    }
//                }
//                Console.Write($ "{r}");
//                r = 'X';
//            }
//            Console.WriteLine();


//        }
//    }
//}
