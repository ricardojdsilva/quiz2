using System;
using System.Collections.Generic;
using System.Text;

namespace RicardoQuiz2_002
{
    class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public double[] mark = new double[10];
        public Course(string id, string name, double[] grade)
        {
            CourseID = id;
            CourseName = name;

            for (int i = 0; i < grade.Length; i++)
            {
                mark[i] = grade[i];

            }

        }

        public double GetAverage
        {
            get
            {
                double sum = 0.0;


                for (int i = 0; i < mark.Length; i++)
                {
                    sum += mark[i];
                }

                return sum / mark.Length;

            }

        }

        public double GetLowest
        {
            get
            {

                double minValue = mark[0];
                for (int i = 1; i < mark.Length; i++)
                {
                    if (mark[i] < minValue)
                    {
                        minValue = mark[i];
                    }
                }
                 return minValue;
            }

        }




        public override string ToString()
        {
           
            return "Course Id:" + CourseID + "Course name: " + CourseName +
                   "\nAverage marks obtained : " + GetAverage.ToString("##.##") +
                   "\nLowest marks : " + GetLowest.ToString("##.##");
        }

    }
}
