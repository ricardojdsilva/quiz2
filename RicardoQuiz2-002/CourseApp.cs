using System;

namespace RicardoQuiz2_002
{
    class CourseApp
    {
        static void Main(string[] args)
        {

            const int qty_students = 10;
            int j = 0;
            double dmarks = 0.0;
            string CourseName = "";
            string CourseID = "";
            double[] vGrade = new double[10];


            Course[] NCourse = new Course[qty_students];

            Console.Write("Enter course Id :");
            CourseID = Console.ReadLine();
            //ClassCourse.CourseID = Convert.ToInt32(Console.ReadLine());

            // NewStudents[i] = new Student() { StudentID = i };

            Console.Write("Enter course name :");
          
           CourseName = Console.ReadLine();


            while (j < qty_students)
            {

                // Enter marks for student# 3
                Console.Write("Enter mark for student {0} :", j+1);

                vGrade[j] = Convert.ToDouble(Console.ReadLine());

                j++;
            }


            NCourse[0] = new Course(CourseID, CourseName, vGrade);

            Console.WriteLine(NCourse[0].ToString());

            Console.ReadKey();

        }
    }
}
