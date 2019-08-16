using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {

        private Gender gender;
        private DateTime birthDate;

        public string Name { get; set; }

        public DateTime BirthDate {
            get => birthDate;
            set
            {
                if(value > DateTime.Now)
                {
                    throw new ArgumentException("Future birthdate is not allowed!");
                }
                birthDate = value;
            }
        }

        public Gender Gender { get => gender; set => gender = value; }

        public Person(string name, DateTime birthDate, Gender gender)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return string.Format("The person name: {0}, birth date: {1}, gender: {2}", Name, BirthDate, Gender);
        }
    }

    enum Gender : byte
    {
        Male,
        Female
    }
}
