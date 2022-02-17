using System;
using System.Collections.Generic;
using System.Text;

namespace P129Inheritance
{
    class Human
    {
        //Clasinn Memmberlerinin Default Access Modifieri - private Olur

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 8)
                {
                    _name = value;
                    return;
                }
                Console.WriteLine("Duzgun Add Daxil Edin");
            }
        }
        private string _surname;
        public string SurName 
        { 
            //Accessorlarin Default Acces Modifier-i Public Amma deyismekde Olur
            get; 
            set; 
        }

        //Encapsulation
        private byte _age;
        public byte Age 
        {
            //Accessor
            //Methoddular
            get
            {
                return _age;
            }
            set
            {
                if (value >= 18 && value <= 65)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Daxil Deyer Duzgun");
                }
            }
        }

        //public void SetAge(byte age)
        //{
        //    if (age >= 18 && age <= 65)
        //    {
        //        _age = age;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Daxil Deyer Duzgun");
        //    }
        //}

        //public byte GetAge()
        //{
        //    return _age;
        //}

        public Human()
        {

        }

        public Human(string name):this()
        {
            Name = name;
        }

        public Human(string name, string surname) : this(name)
        {
            SurName = surname;
        }

        public string GetFullName()
        {
            return $"{Name} {SurName} {_age}";
        }

        //Polymorphisym
        //First Of All Method Set Virtual Keyword
        public virtual string GetInfo()
        {
            return $"{GetFullName()} {Age}";
        }
    }
}
