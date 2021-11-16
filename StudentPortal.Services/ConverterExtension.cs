using StudentPortal.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal
{
    public static class ConverterExtension
    {
        //VM to MOdel
        public static Student ConvertVMToModel(this StudentViewModel source)
        {


            Student destination = new Student()
            {
                // Percentage = source.Percentage.ToString(),
                StudentId = source.StudentId,
                StudentName = source.StudentName,
                StudentPhone = source.StudentPhone,
                Marks1 = source.Marks1,
                Marks2 = source.Marks2,
                Marks3 = source.Marks3,

            };
            return destination;
        }
        public static StudentViewModel ConvertModelToVM(this Student source)
        {
            StudentViewModel destination = new StudentViewModel()
            {
                //Percentage = System.Convert.ToInt32(source.Percentage),
                StudentId = source.StudentId,
                StudentName = source.StudentName,
                StudentPhone = source.StudentPhone,
                Marks1 = source.Marks1,
                Marks2 = source.Marks2,
                Marks3 = source.Marks3,

            };
            return destination;
        }
    }
}
