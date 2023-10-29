using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_review
{
    public interface IStudent
    {
        void AddCredits(int credits);
        void AddGrades(int grade);
        void ConvertGrades(int percentage);
        void PrintGrades();
        void PrintStudentInfo();
        void PrintLastGrade();
        void ChangeStudentStatus();
    }
}
