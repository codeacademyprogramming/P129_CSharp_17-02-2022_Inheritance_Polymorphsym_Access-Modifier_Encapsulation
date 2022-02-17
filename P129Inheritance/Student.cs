using System;
using System.Collections.Generic;
using System.Text;

namespace P129Inheritance
{
    //Access Modifier
    //public - Her Yerden El Catanliq
    //private - Yalniz Clasin Kod Bloklari Daxilinde
    //protected - Clasin Kod Bloklari Daxilinde Ve Klassdan Miras Alan Klassda El Catanliq
    //Readonly - Yalniz Clasin Constructorun Deyer Set Oluna Biler
    //Amma Deyerinin Get Onun Acces Modifiere Gore Deyisir


    //Inheritance(Extentend (Humna Classini Extenten Studente Cevirdim))
    class Student : Human
    {
        private readonly int Grade;
        public string Major;

        public Student(int grade)
        {
            Grade = grade;
        }

        public Student(string name) : base(name)
        {

        }

        public Student(string name, string surname) : base(name, surname)
        {

        }

        //Polymorphysim
        //If You Want Use Polymorphsym you Can set ovverride
        public override string GetInfo()
        {
            

            return $"{base.GetInfo()} {Grade} {Major}";
        }
    }
}
