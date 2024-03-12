/*
Oratile Hlatshwayo - 577279
Omphile Tladi - 577776
Mosifane Mosifane - 577306
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgiumCampusProject.BusinessLogic
{
    internal class Student
    {
        int studentNumber;
        string firstName, surname, dateofbirth, gender, phone, address, moduleCodes;

        public int StudentNumber { get { return studentNumber; } }
        public string FirstName { get { return firstName; } }
        public string Surname { get { return surname; } }
        public string DateofBirth { get { return dateofbirth; } }
        public string Phone { get { return phone; } }
        public string Gender { get { return gender; } }
        public string Address { get { return address; } }
        public string ModuleCodes { get { return moduleCodes; } }


        public Student(int studentNumber, string firstName, string surname, string dateofbirth, string gender, string phone, string address, string moduleCodes)
        {
            this.studentNumber = studentNumber;
            this.firstName = firstName;
            this.surname = surname;
            this.dateofbirth = dateofbirth;
            this.gender = gender;
            this.phone = phone;
            this.address = address;
            this.moduleCodes = moduleCodes;
        }
    }
}

