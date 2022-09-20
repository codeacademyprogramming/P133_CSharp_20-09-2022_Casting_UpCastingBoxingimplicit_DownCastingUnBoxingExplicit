using System;
using Casting.Interfaces;
using Casting.Models;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            //UpCasting, Boxing, Implicity
            //Developer developer = new Developer();
            //developer.Name = "Hamid";

            //object castObject = developer;

            //DownCasting, UnBoxing, Explicity
            //ver 1 - Wrong way
            //Doctor student = (Doctor)developer;

            //ver 1 - True Way with 'is' operator
            //Console.WriteLine(developer is Developer);
            //if (developer is Doctor)
            //{
            //    Doctor doctor = (Doctor)developer;
            //}
            //else
            //{
            //    Student student = (Student)developer;
            //    Developer developer1 = (Developer)developer;
            //}

            //ver 2 - True Way with 'as' operator
            //Doctor doctor = castObject as Doctor;
            //if (doctor != null)
            //{
            //    doctor.Salary = 500;
            //    Console.WriteLine(doctor.Salary);
            //    Console.WriteLine(doctor.Name);
            //    Console.WriteLine("Cevrildi");
            //}else
            //{
            //    Student student = developer as Student;
            //    Console.WriteLine(student.Name);

            //    Console.WriteLine("Cevrilmedi");
            //}


            Developer developer = new Developer 
            {
                Age = 15,
                Skil = "Yatmaq, Coxlu Kofe Icme, Icib Yatmaq 15"
            };
            Developer developer1 = new Developer
            {
                Age = 19,
                Skil = "Yatmaq, Coxlu Kofe Icme, Icib Yatmaq 19"
            };
            Developer developer2 = new Developer
            {
                Age = 17,
                Skil = "Yatmaq, Coxlu Kofe Icme, Icib Yatmaq 17"
            };
            Developer developer3 = new Developer
            {
                Age = 21,
                Skil = "Yatmaq, Coxlu Kofe Icme, Icib Yatmaq 21"
            };
            Developer developer4 = new Developer
            {
                Age = 65,
                Skil = "Yatmaq, Coxlu Kofe Icme, Icib Yatmaq 65"
            };

            Developer[] developers = { developer, developer1, developer2, developer3, developer4 };

            Student student = new Student
            {
                Age = 16,
                Grade = 1635
            };
            Student student1 = new Student
            {
                Age = 13,
                Grade = 1335
            };
            Student student2 = new Student
            {
                Age = 18,
                Grade = 1835
            };
            Student student3 = new Student
            {
                Age = 12,
                Grade = 1235
            };
            Student student4 = new Student
            {
                Age = 20,
                Grade = 2035
            };

            Student[] students = { student, student1, student2, student3, student4 };

            Doctor doctor = new Doctor
            {
                Age = 25,
                Paccients = "Xesdeler"
            };

            object[] humen = { student, developer, student1,student2,developer3,developer2,doctor,student4,developer1,student3,developer4,"Sttrin",456 };

            Check(humen);
            //Check(students);
        }

        static void Check(object[] humen)
        {
            foreach (object item in humen)
            {
                if (item is Developer)
                {
                    Developer developer = (Developer)item;
                    if (developer.Age > 18)
                    {
                        Console.WriteLine(developer.Skil);
                    }
                }
                else if(item is Doctor)
                {
                    Doctor doctor = (Doctor)item;
                    Console.WriteLine(doctor.Paccients);
                }
                else if(item is Student)
                {
                    Student student = (Student)item;
                    if (student.Age > 15)
                    {
                        Console.WriteLine(student.Grade);
                    }
                }
            }
        }

        //static void Check(Developer[] developers)
        //{
        //    foreach (Developer item in developers)
        //    {
        //        if (item.Age > 18)
        //        {
        //            Console.WriteLine(item.Skil);
        //        }
        //    }
        //}

        //static void Check(Student[] students)
        //{
        //    foreach (Student item in students)
        //    {
        //        if (item.Age > 15)
        //        {
        //            Console.WriteLine(item.Grade);
        //        }
        //    }
        //}
    }
}
