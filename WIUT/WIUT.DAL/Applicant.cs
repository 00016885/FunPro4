using System;

namespace WIUT.DAL
{
    public class Applicant
    {
        private string name;
        private string surname;

        public int Id { get; set; }

        public string Name
        {
            get => name; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");
                name = value;
            }
        }

        public string Surname
        {
            get => surname; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Surname cannot be empty");
                surname = value;
            }
        }

        public string Address { get; set; }

        public DateTime DoB { get; set; }

        public bool IsMarried { get; set; }

        public string PassportNo { get; set; }

        public Course Course { get; set; }

        public Applicant()
        {
        }

        public Applicant(string name, string surname, string address, DateTime doB, bool isMarried, string passportNo, Course course)
        {
            Name = name;
            Surname = surname;
            Address = address;
            DoB = doB;
            IsMarried = isMarried;
            PassportNo = passportNo;
            Course = course;
        }
    }
}