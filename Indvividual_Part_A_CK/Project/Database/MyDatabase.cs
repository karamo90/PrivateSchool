using Project.Core.Entities;
using Project.Database.Pairing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database
{
    class MyDatabase
    {
        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Course> Courses { get; set; }
        public List<Assignment> Assignments { get; set; }

        //Synthetic Data
        public MyDatabase()
        {
            //List of 20 students

            Student s1 = new Student(1, "Christos", "Karamolegkos", new DateTime(1990, 06, 17), 2500);
            Student s2 = new Student(2, "Anna", "Kitou", new DateTime(1989, 08, 27), 3300);
            Student s3 = new Student(3, "Giorgos", "Votsis", new DateTime(1990, 06, 23), 4300);
            Student s4 = new Student(4, "Lefteris", "Ligomenidis", new DateTime(1990, 06, 17), 5300);
            Student s5 = new Student(5, "Dimitris", "Votsis", new DateTime(1987, 11, 02), 1300);
            Student s6 = new Student(6, "Artemis", "Kim", new DateTime(1986, 12, 02), 7300);
            Student s7 = new Student(7, "Leandros", "Athanasiadis", new DateTime(1989, 07, 20), 5500);
            Student s8 = new Student(8, "Simos", "Kordilis", new DateTime(1991, 12, 02), 4400);
            Student s9 = new Student(9, "Giorgos", "Gavrilakis", new DateTime(1990, 07, 17), 17300);
            Student s10 = new Student(10, "Stefania", "Latsoudi", new DateTime(1989, 12, 27), 10300);
            Student s11 = new Student(11, "Aggelos", "Nikolopoulos", new DateTime(1991, 01, 02), 5300);
            Student s12 = new Student(12, "Dimitris", "Atzolidakis", new DateTime(1990, 09, 11), 6600);
            Student s13 = new Student(13, "Nikos", "Mihelis", new DateTime(1992, 06, 04), 4200);
            Student s14 = new Student(14, "Maria", "Valaveri", new DateTime(1991, 09, 02), 5100);
            Student s15 = new Student(15, "Kostas", "Svoronos", new DateTime(1991, 02, 22), 3300);
            Student s16 = new Student(16, "Nina", "Koutsoumpa", new DateTime(1991, 05, 30), 8300);
            Student s17 = new Student(17, "Leonidas", "Bolaris", new DateTime(1988, 12, 06), 6600);
            Student s18 = new Student(18, "Penny", "Maggana", new DateTime(1996, 09, 10), 4300);
            Student s19 = new Student(19, "Eugenia", "Apostolaki", new DateTime(1960, 02, 16), 1300);
            Student s20 = new Student(20, "Ioannis", "Karamolegkos", new DateTime(1959, 01, 08), 2300);


            //List of 8 Trainers

            Trainer t1 = new Trainer(1, "Hector", "Gatsos", Core.Enums.Subject.Csharp);
            Trainer t2 = new Trainer(2, "Giorgos", "Papadopoulos", Core.Enums.Subject.Python);
            Trainer t3 = new Trainer(3, "Leonidas", "Kleomenis", Core.Enums.Subject.Java);
            Trainer t4 = new Trainer(4, "Petros", "Eythymiou", Core.Enums.Subject.Java);
            Trainer t5 = new Trainer(5, "Aris", "Kostakis", Core.Enums.Subject.Csharp);
            Trainer t6 = new Trainer(6, "Eleni", "Kostantinou", Core.Enums.Subject.Java);
            Trainer t7 = new Trainer(7, "Marios", "Kordonis", Core.Enums.Subject.Python);
            Trainer t8 = new Trainer(8, "Maria", "Petrou", Core.Enums.Subject.Python);


            //List of 6 Courses

            Course c1 = new Course(1, "C#-FT", "CB-15", "FullTime", new DateTime(2021, 06, 17), new DateTime(2021, 09, 17), "Learn the fundamentals of C# in three months");
            Course c2 = new Course(2, "C#-PT", "CB-15", "PartTime", new DateTime(2021, 06, 17), new DateTime(2021, 12, 17), "Learn the fundamentals of C# In six months");
            Course c3 = new Course(3, "Python-FT", "CB-15", "FullTime", new DateTime(2021, 08, 15), new DateTime(2021, 11, 15), "Learn the fundamentals of Python in three months");
            Course c4 = new Course(4, "Python-PT", "CB-15", "PartTime", new DateTime(2021, 08, 15), new DateTime(2022, 02, 15), "Learn the fundamentals of Python in six months");
            Course c5 = new Course(5, "Java-FT", "CB-15", "FullTime", new DateTime(2021, 11, 1), new DateTime(2021, 02, 01), "Learn the fundamentals of Java in three months");
            Course c6 = new Course(6, "Java-PT", "CB-15", "PartTime", new DateTime(2021, 11, 1), new DateTime(2022, 05, 01), "Learn the fundamentals of Java in six months");


            //List of 12 Assignments

            Assignment a1 = new Assignment(1, "Loop Theory", 30, 100, new DateTime(2021, 09, 10), "Reveal the basics and advantages of using Loops In C#");
            Assignment a2 = new Assignment(2, "Inheritance", 50, 100, new DateTime(2021, 11, 11), "Reveal the basics and advantages of using Inheritance In Python");
            Assignment a3 = new Assignment(3, "Abstract Classes", 70, 100, new DateTime(2021, 12, 27), "Reveal the basics and advantages of using Abstract classes In Java");
            Assignment a4 = new Assignment(4, "Project SQL", 45, 100, new DateTime(2021, 10, 09), "Reveal the basics and advantages of using SQL in real life Database In C#");
            Assignment a5 = new Assignment(5, "Coding Architecture", 65, 100, new DateTime(2022, 01, 13), "Reveal the basics and advantages of using Architecture-coding In Python");
            Assignment a6 = new Assignment(6, "Law of Demeter", 90, 100, new DateTime(2022, 03, 18), "Reveal the basics and advantages of using the Law of Demeter and its properties In Java");
            Assignment a7 = new Assignment(7, "Final Project C#", 10, 100, new DateTime(2021, 08, 08), "Final Team Project of C#");
            Assignment a8 = new Assignment(8, "Solo Project C#", 100, 100, new DateTime(2021, 10, 10), "Final Solo Project for C#");
            Assignment a9 = new Assignment(9, "Final Project Python", 15, 100, new DateTime(2021, 10, 07), "Final Team Project of Python");
            Assignment a10 = new Assignment(10, "Final Project Java", 20, 100, new DateTime(2022, 01, 19), "Final Team Project Of Java");
            Assignment a11 = new Assignment(11, "Solo Project Java", 40, 100, new DateTime(2022, 01, 15), "Final Solo Project Of Java");
            Assignment a12 = new Assignment(12, "Solo Project Python", 10, 100, new DateTime(2022, 10, 05), "Final Solo Project Of Python");

            //Pair Classes

            //Course-Trainer---Many to Many
            CourseTrainer.Pairing(c1, t1);
            CourseTrainer.Pairing(c1, t5);
            CourseTrainer.Pairing(c2, t1);
            CourseTrainer.Pairing(c3, t2);
            CourseTrainer.Pairing(c3, t7);
            CourseTrainer.Pairing(c4, t8);
            CourseTrainer.Pairing(c4, t2);
            CourseTrainer.Pairing(c5, t3);
            CourseTrainer.Pairing(c5, t6);
            CourseTrainer.Pairing(c6, t4);
            CourseTrainer.Pairing(c6, t6);

            //Student-Course---Many to Many
            StudentCourse.Pairing(s1, c2);
            StudentCourse.Pairing(s1, c3);
            StudentCourse.Pairing(s2, c2);
            StudentCourse.Pairing(s3, c1);
            StudentCourse.Pairing(s3, c2);
            StudentCourse.Pairing(s4, c1);
            StudentCourse.Pairing(s5, c5);
            StudentCourse.Pairing(s5, c6);
            StudentCourse.Pairing(s6, c3);
            StudentCourse.Pairing(s7, c3);
            StudentCourse.Pairing(s7, c4);
            StudentCourse.Pairing(s8, c5);
            StudentCourse.Pairing(s8, c6);
            StudentCourse.Pairing(s9, c1);
            StudentCourse.Pairing(s10, c3);
            StudentCourse.Pairing(s10, c2);
            StudentCourse.Pairing(s11, c5);
            StudentCourse.Pairing(s12, c6);
            StudentCourse.Pairing(s13, c2);
            StudentCourse.Pairing(s13, c5);
            StudentCourse.Pairing(s14, c1);
            StudentCourse.Pairing(s15, c5);
            StudentCourse.Pairing(s15, c6);
            StudentCourse.Pairing(s16, c4);
            StudentCourse.Pairing(s17, c2);
            StudentCourse.Pairing(s18, c1);
            StudentCourse.Pairing(s19, c1);
            StudentCourse.Pairing(s19, c2);
            StudentCourse.Pairing(s20, c2);



            //Assignment-Course---Many to One (one Course can have Many Assignments but one Assignment belongs to one Course only)
            CourseAssignment.Pairing(c1, a1);
            CourseAssignment.Pairing(c2, a4);
            CourseAssignment.Pairing(c2, a7);
            CourseAssignment.Pairing(c3, a2);
            CourseAssignment.Pairing(c3, a5);
            CourseAssignment.Pairing(c4, a9);
            CourseAssignment.Pairing(c1, a8);
            CourseAssignment.Pairing(c5, a6);
            CourseAssignment.Pairing(c6, a10);
            CourseAssignment.Pairing(c6, a3);
            CourseAssignment.Pairing(c5, a11);
            CourseAssignment.Pairing(c3, a12);


            //Assignment-Student---Many to Many

            StudentAssignment.Pairing(s1, a4);
            StudentAssignment.Pairing(s1, a7);
            StudentAssignment.Pairing(s1, a2);
            StudentAssignment.Pairing(s1, a5);
            StudentAssignment.Pairing(s1, a12);
            StudentAssignment.Pairing(s2, a4);
            StudentAssignment.Pairing(s2, a7);
            StudentAssignment.Pairing(s3, a1);
            StudentAssignment.Pairing(s3, a4);
            StudentAssignment.Pairing(s3, a7);
            StudentAssignment.Pairing(s4, a1);
            StudentAssignment.Pairing(s4, a8);
            StudentAssignment.Pairing(s5, a3);
            StudentAssignment.Pairing(s5, a6);
            StudentAssignment.Pairing(s5, a10);
            StudentAssignment.Pairing(s5, a11);
            StudentAssignment.Pairing(s6, a2);
            StudentAssignment.Pairing(s6, a5);
            StudentAssignment.Pairing(s6, a12);
            StudentAssignment.Pairing(s7, a2);
            StudentAssignment.Pairing(s7, a5);
            StudentAssignment.Pairing(s7, a9);
            StudentAssignment.Pairing(s7, a12);
            StudentAssignment.Pairing(s8, a3);
            StudentAssignment.Pairing(s8, a6);
            StudentAssignment.Pairing(s8, a10);
            StudentAssignment.Pairing(s8, a11);
            StudentAssignment.Pairing(s9, a1);
            StudentAssignment.Pairing(s9, a8);
            StudentAssignment.Pairing(s10, a2);
            StudentAssignment.Pairing(s10, a4);
            StudentAssignment.Pairing(s10, a5);
            StudentAssignment.Pairing(s10, a7);
            StudentAssignment.Pairing(s10, a12);
            StudentAssignment.Pairing(s11, a6);
            StudentAssignment.Pairing(s11, a11);
            StudentAssignment.Pairing(s12, a3);
            StudentAssignment.Pairing(s12, a10);
            StudentAssignment.Pairing(s13, a4);
            StudentAssignment.Pairing(s13, a6);
            StudentAssignment.Pairing(s13, a7);
            StudentAssignment.Pairing(s13, a11);
            StudentAssignment.Pairing(s14, a1);
            StudentAssignment.Pairing(s14, a8);
            StudentAssignment.Pairing(s15, a3);
            StudentAssignment.Pairing(s15, a6);
            StudentAssignment.Pairing(s15, a10);
            StudentAssignment.Pairing(s15, a11);
            StudentAssignment.Pairing(s16, a9);
            StudentAssignment.Pairing(s17, a4);
            StudentAssignment.Pairing(s17, a7);
            StudentAssignment.Pairing(s18, a1);
            StudentAssignment.Pairing(s18, a8);
            StudentAssignment.Pairing(s19, a1);
            StudentAssignment.Pairing(s19, a4);
            StudentAssignment.Pairing(s19, a7);
            StudentAssignment.Pairing(s19, a8);
            StudentAssignment.Pairing(s20, a4);
            StudentAssignment.Pairing(s20, a7);


            //Populate Data (Fill the Lists)

            Students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 };
            Trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7, t8 };
            Courses = new List<Course>() { c1, c2, c3, c4, c5, c6 };
            Assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12 };





        }
    }
}
