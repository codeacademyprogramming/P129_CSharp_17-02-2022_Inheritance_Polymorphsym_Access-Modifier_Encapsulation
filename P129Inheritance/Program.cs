using System;

namespace P129Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Name = "Parviz";
            //student.SurName = "Alizade";
            //student.Age = 19;
            //student.Grade = 517;
            //student.Major = "IT";

            //Console.WriteLine($"Ad: {student.Name}\nSoyAd: " +
            //    $"{student.SurName}\nYas: {student.Age}\nQiymeti: {student.Grade}");

            //Console.WriteLine(student.GetFullName());

            Human human = new Human("Hamidasdadas","Mammadov");
            human.Age = 25;
            human.SurName = "TEst";
            Console.WriteLine(human.Age);
            Console.WriteLine(human.SurName);
            Console.WriteLine(human.GetFullName());

            //human.SetAge(18);
            //Console.WriteLine(human.GetAge());

            //Console.WriteLine(human.GetFullName());

            //Teacher teacher = new Teacher();
            //Student student = new Student();
            //Console.WriteLine(student.Grade);
            
        }
    }
}
