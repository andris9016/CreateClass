using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    ///<summary>
    ///The main <c>Person</c> class.
    ///Containing all fields and methods about this class
    ///</summary>
    ///<remarks>
    ///Person has a name, birth date, and gender
    ///</remarks>
    class Person
    {

        private Gender gender;
        private DateTime birthDate;

        /// <value>
        /// Gets value of the person name, and sets it.
        /// </value>
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

        /// <summary>
        /// Overriding the original ToSTring method.
        /// </summary>
        /// <returns>string</returns>
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
