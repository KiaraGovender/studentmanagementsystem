using System.Collections.Generic;

namespace studentmanagement{


    /*
        Single Responsibility Principle
        This class has one responisibility which is to provide 
        a list to store both types of students
    */
    
    public static class StudentList{

        public static List<Student> Students = new List<Student>();
        
    }

}