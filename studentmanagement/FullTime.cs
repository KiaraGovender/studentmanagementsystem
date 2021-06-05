namespace studentmanagement
{
    public class FullTime : Student, Submit
    {
        public int GroupNo { get; set; }

        public FullTime(string studentId, string name, string surname, string contactNo, string course, bool enrolled, int groupNo)
                                        : base(studentId, name, surname, contactNo, course, enrolled){ 
            
            GroupNo = groupNo;
        }

        //the ToString method has been overrided to add the group number, which is only applicable to full time students
        public override string ToString()
        {
            return base.ToString() + ", Group " + GroupNo;
        }
    }
}