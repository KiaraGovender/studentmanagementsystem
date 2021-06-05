using System;
using System.Collections.Generic;
using System.Linq;

namespace studentmanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList.Students = FileManager.ReadFile(); //Read the text file and store it in a list

            DisplayMenu();
        }
    }
}
