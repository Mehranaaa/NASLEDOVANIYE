using System;

namespace NASLEDOVANIYE
{
    class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {

                    Console.WriteLine("Write surname");
                    string b = Console.ReadLine();
                    Console.WriteLine("Write course of study");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write grade number book");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Student a = new Student(b, c, d);


                    Console.WriteLine("Write name");
                    string e = Console.ReadLine();
                    Aspirant j = new Aspirant(e, b, c, d);
                    j.Print();
                    bool name = true;
                    foreach (char i in e)
                    {
                        if (i >= '0' && i <= '9')
                        {
                            name = false;
                            Console.WriteLine("input letters");
                            break;
                        }
                    }
                    if (name == false)
                    {
                        continue;
                    }
                    break;
                }
            }

            /*Console.WriteLine("Write surname");
            string f = Console.ReadLine();
            Console.WriteLine("Write course of study");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write grade number book");
            int h = Convert.ToInt32(Console.ReadLine());*/
        }
}
    class Student

    {
        public string Surname

        {
            get;

            set;


        }
        public int Course_of_study
        {

            get;

            set;
        }
        public int Grade_book_number { get; set; }

        public Student(string surname, int course_of_study, int grade_book_number)
        {
            Surname = surname;
            Course_of_study = course_of_study;
            Grade_book_number = grade_book_number;
        }

    }
    class Aspirant : Student
    {
        public string Name { get; set; }

        public Aspirant(string name, string surname, int course_of_study, int grade_book_number)
            : base(surname, course_of_study, grade_book_number)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine($"name {Name} ,surname {Surname} ,course of study {Course_of_study} ,grade book number {Grade_book_number}");
        }
    }

 