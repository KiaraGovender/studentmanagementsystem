using System;

namespace studentmanagement
{
    public class PartTime : Student, Submit
    {
        
        public PartTime(string studentId, string name, string surname, string contactNo, string course, bool enrolled) : 
                                    base(studentId, name, surname,contactNo, course, enrolled)
        { 
            //constructor    
        }
    }
}