namespace Student
{
    using System;
    using System.Collections.Generic;
    public class Student
    {
        // fields
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private int phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

        // properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                this.facultyNumber = value;
            }
        }

        public int Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }

        public IList<int> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                this.groupNumber = value;
            }
        }

        // Constructors
        public Student()
        {
        }
        public Student(string firstName, string lastName, int age, int facultyNumber, int groupNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FacultyNumber = facultyNumber;
            GroupNumber = groupNumber;
        }

        public Student(string firstName, string lastName, int age, int facultyNumber, int groupNumber, IList<int> marks)
            : this(firstName, lastName, age, facultyNumber, groupNumber)
        {
            Marks = marks;
        }

        public Student(string firstName, string lastName, int age, int facultyNumber, int phone, string email, IList<int> marks, int groupNumber)
            : this(firstName, lastName, age, facultyNumber, groupNumber, marks)
        {
            Phone = phone;
            Email = email;
        }
    }
}
