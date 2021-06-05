using System;

namespace studentmanagement
{
    public abstract class Student : Submit{
        protected string StudentId { get; set; }     
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected string ContactNo { get; set; }
        protected string Course { get; set; }
        protected bool Enrolled { get; set; }

        public Student(string studentId, string name, string surname, string contactNo, string course, bool enrolled)
        {
            this.StudentId = studentId;
            this.Name = name;
            this.Surname = surname;
            this.ContactNo = contactNo;
            this.Course= course;
            this. Enrolled = enrolled;
        }

        // public void submitAssessment(){
        //     //submit assessment
        // }

        public void SubmitTest(){
            //submit test
        }

        public void SubmitExam(){
            //submit exam
        }

        public void SubmitAssignment(){
            //submit assignment
        }
                
        public override string ToString()
        {
            string output = StudentId+",\t"+ Name + " " + Surname + ",\t" + Course;

            return output;
        }
    }
}